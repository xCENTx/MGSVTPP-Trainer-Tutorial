
namespace MetalGearTutorial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmmoLabel = new System.Windows.Forms.Label();
            this.FreezeAmmo_checkbox = new System.Windows.Forms.CheckBox();
            this.AmmoTextBox = new System.Windows.Forms.TextBox();
            this.SendAmmo_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Enabled = true;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.AutoSize = true;
            this.ProcessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessLabel.Location = new System.Drawing.Point(12, 9);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(57, 20);
            this.ProcessLabel.TabIndex = 0;
            this.ProcessLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "AMMO :";
            // 
            // AmmoLabel
            // 
            this.AmmoLabel.AutoSize = true;
            this.AmmoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmmoLabel.Location = new System.Drawing.Point(90, 44);
            this.AmmoLabel.Name = "AmmoLabel";
            this.AmmoLabel.Size = new System.Drawing.Size(19, 20);
            this.AmmoLabel.TabIndex = 2;
            this.AmmoLabel.Text = "#";
            // 
            // FreezeAmmo_checkbox
            // 
            this.FreezeAmmo_checkbox.AutoSize = true;
            this.FreezeAmmo_checkbox.Location = new System.Drawing.Point(138, 48);
            this.FreezeAmmo_checkbox.Name = "FreezeAmmo_checkbox";
            this.FreezeAmmo_checkbox.Size = new System.Drawing.Size(85, 17);
            this.FreezeAmmo_checkbox.TabIndex = 3;
            this.FreezeAmmo_checkbox.Text = "UNLIMITED";
            this.FreezeAmmo_checkbox.UseVisualStyleBackColor = true;
            // 
            // AmmoTextBox
            // 
            this.AmmoTextBox.Location = new System.Drawing.Point(16, 70);
            this.AmmoTextBox.Name = "AmmoTextBox";
            this.AmmoTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmmoTextBox.TabIndex = 4;
            // 
            // SendAmmo_Button
            // 
            this.SendAmmo_Button.Location = new System.Drawing.Point(138, 68);
            this.SendAmmo_Button.Name = "SendAmmo_Button";
            this.SendAmmo_Button.Size = new System.Drawing.Size(75, 23);
            this.SendAmmo_Button.TabIndex = 5;
            this.SendAmmo_Button.Text = "SEND";
            this.SendAmmo_Button.UseVisualStyleBackColor = true;
            this.SendAmmo_Button.Click += new System.EventHandler(this.SendAmmo_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 99);
            this.Controls.Add(this.SendAmmo_Button);
            this.Controls.Add(this.AmmoTextBox);
            this.Controls.Add(this.FreezeAmmo_checkbox);
            this.Controls.Add(this.AmmoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NightFyreTV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ProcessTimer;
        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AmmoLabel;
        private System.Windows.Forms.CheckBox FreezeAmmo_checkbox;
        private System.Windows.Forms.TextBox AmmoTextBox;
        private System.Windows.Forms.Button SendAmmo_Button;
    }
}

