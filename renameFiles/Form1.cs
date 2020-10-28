using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameCreatedateMd5
{
    public partial class FileRename : Form
    {
        private string dropedPath = "";

        public FileRename()
        {
            InitializeComponent();
        }

        private void renameExecButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("clicked!");
            string[] files = Directory.GetFiles(dropedPath, "*");

            this.progressBar.Minimum = 0;
            this.progressBar.Maximum = files.Length;
            this.progressBar.Value = 0;

            int current = 0;
            try
            {
                foreach (string sourcePath in files)
                {
                    current++;

                    // 変更後のファイル名を作成する
                    FileInfo sourceFileInfo = new FileInfo(sourcePath);
                    StringBuilder changeNameBuilder = new StringBuilder();

                    // yyyymmddhhmmss系
                    if (this.ymdhmsMd5Radio.Checked || this.ymdhmsRadio.Checked)
                    {
                        changeNameBuilder.Append(sourceFileInfo.CreationTime.ToString("yyyyMMddHHmmss"));
                    }
                    if (this.ymdhmsMd5Radio.Checked)
                    {
                        changeNameBuilder.Append("_");
                        changeNameBuilder.Append(calcMd5Hash(sourcePath));
                    }

                    // yyyymmdd系
                    if (this.ymdRadio.Checked || this.ymdMd5Radio.Checked)
                    {
                        changeNameBuilder.Append(sourceFileInfo.CreationTime.ToString("yyyyMMdd"));
                    }
                    if (this.ymdMd5Radio.Checked)
                    {
                        changeNameBuilder.Append("_");
                        changeNameBuilder.Append(calcMd5Hash(sourcePath));
                    }

                    // md5
                    if (this.md5Radio.Checked)
                    {
                        changeNameBuilder.Append(calcMd5Hash(sourcePath));
                    }

                    // 連番
                    if (this.seqRadio.Checked)
                    {
                        changeNameBuilder.Append(current.ToString("D6"));
                    }

                    // 拡張子を除いたパスを生成
                    string destPathWithoutExt = Path.Combine(sourceFileInfo.DirectoryName, changeNameBuilder.ToString());

                    // 拡張子を取得
                    string ext = Path.GetExtension(sourcePath);

                    // 重複処理
                    string destPath = destPathWithoutExt + ext;
                    if (File.Exists(destPathWithoutExt + ext))
                    {
                        int cnt = 0;
                        while (true)
                        {
                            cnt++;

                            string cntStr = "_";
                            if (this.suffix00x.Checked)
                            {
                                cntStr += cnt.ToString("D3");
                            }
                            if (this.suffixX.Checked)
                            {
                                cntStr += cnt.ToString();
                            }

                            destPath = destPathWithoutExt + cntStr + ext;

                            if (!File.Exists(destPath))
                            {
                                break;
                            }
                        }
                    }

                    File.Move(sourcePath, destPath);

                    this.progressBar.Value = current;
                    //updateProgressLabel(current, files.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラーが発生しました\n"+ex.Message);
            }

            MessageBox.Show("処理が完了しました");
        }

        //private void updateProgressLabel(int current, int maximum)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(current.ToString());
        //    sb.Append("/");
        //    sb.Append(maximum.ToString());
        //    this.progressText.Text = sb.ToString();
        //}

        private string calcMd5Hash(string filepath)
        {
            FileStream fs = null;
            MD5CryptoServiceProvider md5 = null;
            byte[] bs = null;
            try
            {
                fs  = new FileStream(filepath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                md5 = new MD5CryptoServiceProvider();
                bs  = md5.ComputeHash(fs);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (md5 != null)
                {
                    md5.Clear();
                }
            }

            StringBuilder result = new StringBuilder();
            foreach (byte b in bs)
            {
                result.Append(b.ToString("x2"));
            }

            return result.ToString();
        }

        private void dropLabel_DragEnter(object sender, DragEventArgs e)
        {
            // ラベルにドラッグされた時にドロップ可能にする
            e.Effect = DragDropEffects.Copy;
        }

        //private void label1_DragOver(object sender, DragEventArgs e)
        //{
        //    //Console.WriteLine("dragover!");
        //}

        private void dropLabel_DragDrop(object sender, DragEventArgs e)
        {
            // ドロップされた時に行う処理
            dropedPath = "";
            this.dropLabel.Text = "リネームするファイルが入ったフォルダをここにドラッグ...";
            this.renameExecButton.Enabled = false;

            // ドロップされたファイルパスを取得
            string[] dropElements = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            if (1 < dropElements.Length)
            {
                // ファイルが複数だった場合は処理対象外
                MessageBox.Show("ドロップするフォルダは1つです");
            }
            else
            {
                string tmpPath = dropElements[0];

                if (File.Exists(tmpPath))
                {
                    // ファイルだった場合は処理対象外
                    MessageBox.Show("ファイルが格納されている親フォルダをドロップしてください");
                }
                else if (Directory.Exists(tmpPath))
                {
                    // ファイルが複数だった場合は処理対象外
                    dropedPath = dropElements[0];
                    this.dropLabel.Text = dropedPath;

                    // 実行ボタン有効化
                    this.renameExecButton.Enabled = true;
                }

            }
            
        }
    }
}
