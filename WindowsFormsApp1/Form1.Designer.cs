
namespace WindowsFormsApp1
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
            this.passportTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passportTextbox
            // 
            this.passportTextbox.Location = new System.Drawing.Point(181, 96);
            this.passportTextbox.Name = "passportTextbox";
            this.passportTextbox.Size = new System.Drawing.Size(394, 20);
            this.passportTextbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "CheckButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // textResult
            // 
            this.textResult.AutoSize = true;
            this.textResult.Location = new System.Drawing.Point(347, 168);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(35, 13);
            this.textResult.TabIndex = 2;
            this.textResult.Text = "label1";
            this.textResult.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passportTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passportTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textResult;
    }
}

