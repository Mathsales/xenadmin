/* Copyright (c) Citrix Systems, Inc. 
 * All rights reserved. 
 * 
 * Redistribution and use in source and binary forms, 
 * with or without modification, are permitted provided 
 * that the following conditions are met: 
 * 
 * *   Redistributions of source code must retain the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer. 
 * *   Redistributions in binary form must reproduce the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer in the documentation and/or other 
 *     materials provided with the distribution. 
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
 * CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
 * INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
 * MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR 
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE 
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
 * SUCH DAMAGE.
 */

using System;
using System.Windows.Forms;
using XenAdmin.Actions;
using XenAdmin.Controls.DataGridViewEx;
using XenAPI;
using System.Collections.Generic;


namespace XenAdmin.SettingsPanels
{
    public class PoolPowerONEditPage : HostPowerONEditPage
    {
        private DataGridViewEx dataGridView2;
        private Button button1;
        private DataGridViewTextBoxColumn _columnHostName;
        private DataGridViewTextBoxColumn _columnPowerOnMode;
        private Pool _pool;

        public PoolPowerONEditPage()
        {
            InitializeComponent();
        }

        public override AsyncAction SaveSettings()
        {
            string newMode, ip, user, password;
            Dictionary<string, string> customConfig;
            GetConfig(out newMode, out ip, out user, out password, out customConfig);
            List<Host> hosts = new List<Host>();
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                hosts.Add((Host)row.Tag);
            return new SavePowerOnSettingsAction(_pool.Connection, hosts, newMode, ip, user, password, customConfig, true);
        }

        public override void SetXenObjects(IXenObject orig, IXenObject clone)
        {
            _pool = (Pool)clone;

            for (int i = 0; i < _pool.Connection.Cache.Hosts.Length; i++)
            {
                Host host = _pool.Connection.Cache.Hosts[i];
                dataGridView2.Rows.Add();
                dataGridView2[_columnHostName.Name, i].Value = host.Name();
                dataGridView2[_columnPowerOnMode.Name, i].Value = GetFullNameMode(host.power_on_mode);
                dataGridView2.Rows[i].Tag = host;
            }
            base.SetXenObjects(_pool.Connection.Cache.Hosts[0], _pool.Connection.Cache.Hosts[0]);

        }
        public override string SubText
        {
            get 
            {
                List<Host> hostCopy = new List<Host>(_pool.Connection.Cache.Hosts);
                if (hostCopy.Count == 0)
                {
                    // Cache not populated
                    return "";
                }
                if (hostCopy.Count > 1)
                {
                    for (int i = 0; i < hostCopy.Count - 1; i++)
                    {
                        if (hostCopy[i].power_on_mode == hostCopy[i + 1].power_on_mode)
                            continue;

                        return Messages.MIXED_POWER_ON_MODE;
                    }
                }

                return GetFullNameMode(hostCopy[0].power_on_mode);
            }
        }

        public static string GetFullNameMode(string power_on_mode)
        {
            switch (power_on_mode)
            {
                case "":
                case null:
                    return Messages.DISABLED;
                case "wake-on-lan":
                    return Messages.WAKE_ON_LAN;
                default:
                    return power_on_mode;
            }
        }


        #region autogenerated
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoolPowerONEditPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new XenAdmin.Controls.DataGridViewEx.DataGridViewEx();
            this._columnHostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnPowerOnMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCredentials
            // 
            resources.ApplyResources(this.groupBoxCredentials, "groupBoxCredentials");
            // 
            // groupBoxMode
            // 
            resources.ApplyResources(this.groupBoxMode, "groupBoxMode");
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnHostName,
            this._columnPowerOnMode});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.MultiSelect = true;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // ColumnHostName
            // 
            resources.ApplyResources(this._columnHostName, "_columnHostName");
            this._columnHostName.Name = "ColumnHostName";
            this._columnHostName.ReadOnly = true;
            // 
            // ColumnPowerONMode
            // 
            resources.ApplyResources(this._columnPowerOnMode, "_columnPowerOnMode");
            this._columnPowerOnMode.Name = "ColumnPowerONMode";
            this._columnPowerOnMode.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PoolPowerONEditPage
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Name = "PoolPowerONEditPage";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.groupBoxMode, 0);
            this.Controls.SetChildIndex(this.groupBoxCredentials, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.SelectAll();
            dataGridView2.Select();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            bool isUniform = true;
            if (dataGridView2.SelectedRows.Count > 0 && dataGridView2.SelectedRows[0].Tag is Host)
            {
                Host firstHost = (Host)dataGridView2.SelectedRows[0].Tag;
                foreach (DataGridViewRow selectedHost in dataGridView2.SelectedRows)
                {
                    Host currentHost = (Host)selectedHost.Tag;
                    if (currentHost.power_on_mode != firstHost.power_on_mode)
                    {
                        isUniform = false;
                        break;
                    }
                }
                if (isUniform)
                    base.SetXenObjects(firstHost, firstHost);
                else
                {
                    base.radioButtonDisabled.Checked = true;
                }
            }
            else
            {
                dataGridView2.Rows[0].Selected = true;
            }

        }


    }
}
