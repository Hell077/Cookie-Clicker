namespace Cookie_Clicker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cookie_click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cookie_click
            // 
            this.Cookie_click.BackColor = System.Drawing.Color.White;
            this.Cookie_click.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cookie_click.BackgroundImage")));
            this.Cookie_click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cookie_click.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cookie_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cookie_click.ForeColor = System.Drawing.SystemColors.Control;
            this.Cookie_click.Location = new System.Drawing.Point(349, 286);
            this.Cookie_click.Name = "Cookie_click";
            this.Cookie_click.Size = new System.Drawing.Size(165, 152);
            this.Cookie_click.TabIndex = 0;
            this.Cookie_click.UseVisualStyleBackColor = false;
            this.Cookie_click.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26.25F);
            this.label1.Location = new System.Drawing.Point(346, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 46);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLICK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cookie_click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cookie_click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

