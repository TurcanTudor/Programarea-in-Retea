namespace PR_Lab3_Sample
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.crawlerRichTextBox = new System.Windows.Forms.RichTextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.crawlerBtn = new System.Windows.Forms.Button();
               this.methodsRichTextBox = new System.Windows.Forms.RichTextBox();
               this.post_btn = new System.Windows.Forms.Button();
               this.get_btn = new System.Windows.Forms.Button();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.Head = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(12, 31);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(358, 20);
               this.textBox1.TabIndex = 0;
               // 
               // crawlerRichTextBox
               // 
               this.crawlerRichTextBox.Location = new System.Drawing.Point(376, 12);
               this.crawlerRichTextBox.Name = "crawlerRichTextBox";
               this.crawlerRichTextBox.Size = new System.Drawing.Size(380, 245);
               this.crawlerRichTextBox.TabIndex = 1;
               this.crawlerRichTextBox.Text = "";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(12, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(101, 13);
               this.label1.TabIndex = 2;
               this.label1.Text = "Input the URL here:";
               // 
               // crawlerBtn
               // 
               this.crawlerBtn.Location = new System.Drawing.Point(144, 57);
               this.crawlerBtn.Name = "crawlerBtn";
               this.crawlerBtn.Size = new System.Drawing.Size(87, 23);
               this.crawlerBtn.TabIndex = 3;
               this.crawlerBtn.Text = "Search links";
               this.crawlerBtn.UseVisualStyleBackColor = true;
               this.crawlerBtn.Click += new System.EventHandler(this.crawlerBtn_Click);
               // 
               // methodsRichTextBox
               // 
               this.methodsRichTextBox.Location = new System.Drawing.Point(376, 273);
               this.methodsRichTextBox.Name = "methodsRichTextBox";
               this.methodsRichTextBox.Size = new System.Drawing.Size(380, 412);
               this.methodsRichTextBox.TabIndex = 4;
               this.methodsRichTextBox.Text = "";
               // 
               // post_btn
               // 
               this.post_btn.Location = new System.Drawing.Point(163, 318);
               this.post_btn.Name = "post_btn";
               this.post_btn.Size = new System.Drawing.Size(83, 23);
               this.post_btn.TabIndex = 5;
               this.post_btn.Text = "PostRequest";
               this.post_btn.UseVisualStyleBackColor = true;
               this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
               // 
               // get_btn
               // 
               this.get_btn.Location = new System.Drawing.Point(56, 318);
               this.get_btn.Name = "get_btn";
               this.get_btn.Size = new System.Drawing.Size(75, 23);
               this.get_btn.TabIndex = 6;
               this.get_btn.Text = "GetRequest";
               this.get_btn.UseVisualStyleBackColor = true;
               this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(12, 283);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(358, 20);
               this.textBox2.TabIndex = 7;
               // 
               // Head
               // 
               this.Head.Location = new System.Drawing.Point(263, 318);
               this.Head.Name = "Head";
               this.Head.Size = new System.Drawing.Size(83, 23);
               this.Head.TabIndex = 8;
               this.Head.Text = "Head";
               this.Head.UseVisualStyleBackColor = true;
               this.Head.Click += new System.EventHandler(this.Head_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::PR_Lab3_Sample.Properties.Resources.icon128_2x;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.ClientSize = new System.Drawing.Size(768, 535);
               this.Controls.Add(this.Head);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.get_btn);
               this.Controls.Add(this.post_btn);
               this.Controls.Add(this.methodsRichTextBox);
               this.Controls.Add(this.crawlerBtn);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.crawlerRichTextBox);
               this.Controls.Add(this.textBox1);
               this.DoubleBuffered = true;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "Form1";
               this.Text = "HTTP Client";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.RichTextBox crawlerRichTextBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button crawlerBtn;
          private System.Windows.Forms.RichTextBox methodsRichTextBox;
          private System.Windows.Forms.Button post_btn;
          private System.Windows.Forms.Button get_btn;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.Button Head;
     }
}

