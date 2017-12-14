/*
 * Copyright © 2017  Hasher Development Team
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you
 * may not use this file except in compliance with the License.
 * 
 * You may obtain a copy of the License at:
 * https://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
 * implied.
 * 
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using SHA3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasher
{
    public partial class HasherForm : Form
    {
        public HasherForm()
        {
            InitializeComponent();
        }

        private CancellationTokenSource _tokenSource;
        private const string BrowseStringMnemonic = "&Browse...";
        private const string CalculatingString = "Calculating...";
        private const string CancelStringMnemonic = "&Cancel";
        private const string CancellingString = "Cancelling";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (_tokenSource == null)
            {
                var res = openFileDialog1.ShowDialog(this);
                if (res == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName) && File.Exists(openFileDialog1.FileName))
                {
                    _tokenSource = new CancellationTokenSource();

                    foreach (var tb in new[] { tbFileName, tbSHA1, tbSHA256, tbSHA512, tbSHA3256, tbSHA3512 })
                        tb.Text = CalculatingString;
                    btnBrowse.Text = CancelStringMnemonic;
                    tbFileName.Text = openFileDialog1.FileName;
                    Hash(openFileDialog1.FileName, _tokenSource.Token);
                }
            }
            else
            {
                _tokenSource?.Cancel();
                btnBrowse.Text = CancellingString;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var tb in this.Controls.OfType<TextBox>().Where(t => t != tbFileName && !string.IsNullOrEmpty(t.Text) && !t.Text.Equals(CalculatingString)))
            {
                SetOutputText(tb, tb.Text);
            }
        }

        private void CleanupTasks()
        {
            foreach (var tb in new[] { tbSHA1, tbSHA256, tbSHA512, tbSHA3256, tbSHA3512 }.Where(t => t.Text.Equals(CalculatingString)))
            {
                tb.Text = string.Empty;
            }
            btnBrowse.Text = BrowseStringMnemonic;

            _tokenSource?.Dispose();
            _tokenSource = null;
        }


        private async void Hash(string fileName, CancellationToken token)
        {
            var md5 = Task.Factory.StartNew(() => HashMd5(fileName, token, tbMD5), token).Unwrap();
            var sha1 = Task.Factory.StartNew(() => HashSha1(fileName, token, tbSHA1), token).Unwrap();
            var sha2_256 = Task.Factory.StartNew(() => HashSha2_256(fileName, token, tbSHA256), token).Unwrap();
            var sha2_512 = Task.Factory.StartNew(() => HashSha2_512(fileName, token, tbSHA512), token).Unwrap();
            var sha3_256 = Task.Factory.StartNew(() => HashSha3_256(fileName, token, tbSHA3256), token).Unwrap();
            var sha3_512 = Task.Factory.StartNew(() => HashSha3_512(fileName, token, tbSHA3512), token).Unwrap();

            try
            {
                await Task.WhenAll(md5, sha1, sha2_256, sha2_512, sha3_256, sha3_512);
            }
            catch (Exception ex) when (!(ex is OperationCanceledException))
            {
                while (ex != null)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                    ex = ex.InnerException;
                }
            }

            Invoke(new Action(() => CleanupTasks()));
        }

        private Task HashMd5(string fileName, CancellationToken token, TextBox tb)
        {
            return Task.Factory.StartNew(() =>
            {
                token.ThrowIfCancellationRequested();

                using (var stream = File.OpenRead(fileName))
                using (var md5m = new MD5CryptoServiceProvider())
                {
                    string res = BitConverter.ToString(md5m.ComputeHash(stream)).Replace("-", string.Empty);
                    SetOutputText(tb, res);
                }
            });
        }

        private Task HashSha1(string fileName, CancellationToken token, TextBox tb)
        {
            return Task.Factory.StartNew(() =>
            {
                token.ThrowIfCancellationRequested();

                using (var stream = File.OpenRead(fileName))
                using (var sha1 = new SHA1Managed())
                {
                    string res = BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", string.Empty);
                    SetOutputText(tb, res);
                }
            });
        }

        private Task HashSha2_256(string fileName, CancellationToken token, TextBox tb)
        {
            return Task.Factory.StartNew(() =>
            {
                token.ThrowIfCancellationRequested();

                using (var stream = File.OpenRead(fileName))
                using (var sha2 = new SHA256Managed())
                {
                    string res = BitConverter.ToString(sha2.ComputeHash(stream)).Replace("-", string.Empty);
                    SetOutputText(tb, res);
                }
            });
        }

        private Task HashSha2_512(string fileName, CancellationToken token, TextBox tb)
        {
            return Task.Factory.StartNew(() =>
            {
                token.ThrowIfCancellationRequested();

                using (var stream = File.OpenRead(fileName))
                using (var sha2 = new SHA512Managed())
                {
                    string res = BitConverter.ToString(sha2.ComputeHash(stream)).Replace("-", string.Empty);
                    SetOutputText(tb, res);
                }
            });
        }

        private Task HashSha3_256(string fileName, CancellationToken token, TextBox tb)
        {
            return Task.Factory.StartNew(() =>
            {
                token.ThrowIfCancellationRequested();

                using (var stream = File.OpenRead(fileName))
                using (var sha3 = new SHA3Managed(256))
                {
                    string res = BitConverter.ToString(sha3.ComputeHash(stream)).Replace("-", string.Empty);
                    SetOutputText(tb, res);
                }
            });
        }

        private Task HashSha3_512(string fileName, CancellationToken token, TextBox tb)
        {
            return Task.Factory.StartNew(() =>
            {
                token.ThrowIfCancellationRequested();

                using (var stream = File.OpenRead(fileName))
                using (var sha3 = new SHA3Managed(512))
                {
                    string res = BitConverter.ToString(sha3.ComputeHash(stream)).Replace("-", string.Empty);
                    SetOutputText(tb, res);
                }
            });
        }

        private void SetOutputText(TextBox tb, string text)
        {
            text = text ?? string.Empty;
            text = cbUpperCase.Checked ? text.ToUpper() : text.ToLower();
            tb.Invoke(new Action(() => tb.Text = text));
        }
    }
}
