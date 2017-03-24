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
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.choose_shape = new System.Windows.Forms.ComboBox();
            this.createShape = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_coordinates
            // 
            this.lb_coordinates.AutoSize = true;
            this.lb_coordinates.Location = new System.Drawing.Point(687, 13);
            this.lb_coordinates.Name = "lb_coordinates";
            this.lb_coordinates.Size = new System.Drawing.Size(0, 13);
            this.lb_coordinates.TabIndex = 0;
            // 
            // timer_refresh
            // 
            this.timer_refresh.Enabled = true;
            this.timer_refresh.Interval = 25;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // choose_shape
            // 
            this.choose_shape.FormattingEnabled = true;
            this.choose_shape.Items.AddRange(new object[] {
            "Circle",
            "Square"});
            this.choose_shape.Location = new System.Drawing.Point(690, 39);
            this.choose_shape.Name = "choose_shape";
            this.choose_shape.Size = new System.Drawing.Size(121, 21);
            this.choose_shape.TabIndex = 3;
            this.choose_shape.Text = "Pick a shape";
            this.choose_shape.SelectedIndexChanged += new System.EventHandler(this.choose_shape_SelectedIndexChanged);
            // 
            // createShape
            // 
            this.createShape.Location = new System.Drawing.Point(690, 67);
            this.createShape.Name = "createShape";
            this.createShape.Size = new System.Drawing.Size(121, 23);
            this.createShape.TabIndex = 4;
            this.createShape.Text = "Create Shape";
            this.createShape.UseVisualStyleBackColor = true;
            this.createShape.Click += new System.EventHandler(this.createMonster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 602);
            this.Controls.Add(this.createShape);
            this.Controls.Add(this.choose_shape);
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
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.ComboBox choose_shape;
        private System.Windows.Forms.Button createShape;
    }
}

