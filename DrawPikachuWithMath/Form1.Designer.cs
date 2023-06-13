namespace DrawPikachuWithMath
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            plZGraph = new Panel();
            hScrollBar1 = new HScrollBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(hScrollBar1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 106);
            panel1.TabIndex = 0;
            // 
            // plZGraph
            // 
            plZGraph.Dock = DockStyle.Fill;
            plZGraph.Location = new Point(0, 106);
            plZGraph.Margin = new Padding(5);
            plZGraph.Name = "plZGraph";
            plZGraph.Size = new Size(1371, 704);
            plZGraph.TabIndex = 1;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(30, 25);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(318, 56);
            hScrollBar1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 810);
            Controls.Add(plZGraph);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private HScrollBar hScrollBar1;
        private TrackBar trackBar1;
        private Panel plZGraph;
    }
}