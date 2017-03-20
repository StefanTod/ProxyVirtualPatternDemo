namespace ProxyVirtualPatternDemo
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
            this.lb_coordinates = new System.Windows.Forms.Label();
            this.btn_transform = new System.Windows.Forms.Button();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_coordinates
            // 
            this.lb_coordinates.AutoSize = true;
            this.lb_coordinates.Location = new System.Drawing.Point(687, 13);
            this.lb_coordinates.Name = "lb_coordinates";
            this.lb_coordinates.Size = new System.Drawing.Size(76, 13);
            this.lb_coordinates.TabIndex = 0;
            this.lb_coordinates.Text = "lb_coordinates";
            // 
            // btn_transform
            // 
            this.btn_transform.Location = new System.Drawing.Point(690, 45);
            this.btn_transform.Name = "btn_transform";
            this.btn_transform.Size = new System.Drawing.Size(75, 23);
            this.btn_transform.TabIndex = 1;
            this.btn_transform.Text = "Create circle";
            this.btn_transform.UseVisualStyleBackColor = true;
            this.btn_transform.Click += new System.EventHandler(this.btn_transform_Click);
            // 
            // timer_refresh
            // 
            this.timer_refresh.Enabled = true;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 602);
            this.Controls.Add(this.btn_transform);
            this.Controls.Add(this.lb_coordinates);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_coordinates;
        private System.Windows.Forms.Button btn_transform;
        private System.Windows.Forms.Timer timer_refresh;
    }
}

