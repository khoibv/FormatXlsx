using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccBear.FormatDocuments
{
    public partial class Settings : Form
    {
        private readonly object MISSING = Type.Missing;

        private System.Drawing.Font selectedFont = new System.Drawing.Font("ＭＳ Ｐゴシック", 9);

        public Settings()
        {
            InitializeComponent();
            ShowFont();
        }

        private void btnInputDir_Click(object sender, EventArgs e)
        {

            var dialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                SelectedPath = Directory.Exists(txtInputDir.Text) ? txtInputDir.Text : Environment.SpecialFolder.Personal.ToString(),
            };

            if (DialogResult.OK == dialog.ShowDialog())
            {
                txtInputDir.Text = dialog.SelectedPath;
            }
        }

        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                SelectedPath = Directory.Exists(txtOutputDir.Text) ? txtOutputDir.Text : Environment.SpecialFolder.Personal.ToString(),
            };

            if (DialogResult.OK == dialog.ShowDialog())
            {
                txtOutputDir.Text = dialog.SelectedPath;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFormatDoc_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            var inputDir = txtInputDir.Text;
            var outputDir = txtOutputDir.Text;

            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            int fileCount = 0;
            foreach (var file in new DirectoryInfo(inputDir).GetFiles("*.xls?", SearchOption.AllDirectories))
            {
                fileCount++;
                var inputWorkbook = Globals.ThisAddIn.Application.Workbooks.Open(
                    Filename: file.FullName,
                    UpdateLinks: MISSING,
                    ReadOnly: MISSING,
                    Format: MISSING,
                    Password: MISSING,
                    WriteResPassword: MISSING,
                    IgnoreReadOnlyRecommended: MISSING,
                    Origin: MISSING,
                    Delimiter: MISSING,
                    Editable: MISSING,
                    Notify: MISSING,
                    Converter: MISSING,
                    AddToMru: MISSING,
                    Local: MISSING,
                    CorruptLoad: MISSING
                    );

                int count = 0;
                foreach (Worksheet sheet in inputWorkbook.Worksheets)
                {
                    // Set fonts
                    sheet.UsedRange.Font.Name = MapFont(selectedFont.Name);
                    sheet.UsedRange.Font.Size = selectedFont.Size;

                    // Page layout
                    sheet.PageSetup.FitToPagesWide = 1;
                    foreach (WorksheetView view in inputWorkbook.Windows[1].SheetViews)
                    {
                        if (view.Sheet.Name == sheet.Name)
                        {
                            view.DisplayGridlines = false;
                            view.Application.ActiveWindow.View = XlWindowView.xlPageBreakPreview;

                            break;
                        }
                    }

                    if (count > 0)
                    {
                        // Print footer
                        // https://msdn.microsoft.com/en-us/library/bb225426
                        sheet.PageSetup.CenterFooter = "&P";
                        sheet.PageSetup.RightFooter = "Copyright (C)Nissho Electronics Corporation  All rights reserved";
                    }
                }

                // if inputDir=D:/ACC/Input
                // and file path=D:/ACC/Input/Function01/Sub001/File01.xlsx
                // then subPath = Function01/Sub001
                var subPath = file.Directory.FullName.Replace(inputDir, string.Empty);
                if (subPath.StartsWith(@"\")) { subPath = subPath.Substring(1); }
                var outputPath = Path.Combine(outputDir, subPath);
                if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }
                var outputFile = Path.Combine(outputPath, file.Name);
                inputWorkbook.SaveAs(Filename: outputFile);
                inputWorkbook.Close();
            }
            this.Enabled = true;
            MessageBox.Show($"Completed. Processed {fileCount} file(s)");
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog
            {
                ShowColor = false,
                Font = selectedFont,
            };

            if (DialogResult.OK == dialog.ShowDialog())
            {
                selectedFont = dialog.Font;
                ShowFont();
            }
        }

        private void ShowFont()
        {
            txtFont.Text = $"{selectedFont.Name}, {selectedFont.Size}";
        }


        private string MapFont(string fontName)
        {
            return fontName == "MS PGothic" ? "ＭＳ Ｐゴシック" : fontName;
        }
    }
}
