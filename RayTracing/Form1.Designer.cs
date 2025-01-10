namespace RayTracing
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frontWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.leftWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.rightWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.upWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.downWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cubeSpecularCB = new System.Windows.Forms.CheckBox();
            this.sphereSpecularCB = new System.Windows.Forms.CheckBox();
            this.refractCubeCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refractSphereCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lightSource1 = new System.Windows.Forms.CheckBox();
            this.lightSource2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 507);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frontWallSpecularCB
            // 
            this.frontWallSpecularCB.AutoSize = true;
            this.frontWallSpecularCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frontWallSpecularCB.Location = new System.Drawing.Point(551, 32);
            this.frontWallSpecularCB.Margin = new System.Windows.Forms.Padding(6);
            this.frontWallSpecularCB.Name = "frontWallSpecularCB";
            this.frontWallSpecularCB.Size = new System.Drawing.Size(76, 17);
            this.frontWallSpecularCB.TabIndex = 0;
            this.frontWallSpecularCB.Text = "Передняя";
            this.frontWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(633, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backWallSpecularCB
            // 
            this.backWallSpecularCB.AutoSize = true;
            this.backWallSpecularCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backWallSpecularCB.Location = new System.Drawing.Point(551, 50);
            this.backWallSpecularCB.Margin = new System.Windows.Forms.Padding(6);
            this.backWallSpecularCB.Name = "backWallSpecularCB";
            this.backWallSpecularCB.Size = new System.Drawing.Size(63, 17);
            this.backWallSpecularCB.TabIndex = 0;
            this.backWallSpecularCB.Text = "Задняя";
            this.backWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // leftWallSpecularCB
            // 
            this.leftWallSpecularCB.AutoSize = true;
            this.leftWallSpecularCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftWallSpecularCB.Location = new System.Drawing.Point(639, 32);
            this.leftWallSpecularCB.Margin = new System.Windows.Forms.Padding(6);
            this.leftWallSpecularCB.Name = "leftWallSpecularCB";
            this.leftWallSpecularCB.Size = new System.Drawing.Size(58, 17);
            this.leftWallSpecularCB.TabIndex = 0;
            this.leftWallSpecularCB.Text = "Левая";
            this.leftWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // rightWallSpecularCB
            // 
            this.rightWallSpecularCB.AutoSize = true;
            this.rightWallSpecularCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightWallSpecularCB.Location = new System.Drawing.Point(639, 50);
            this.rightWallSpecularCB.Margin = new System.Windows.Forms.Padding(6);
            this.rightWallSpecularCB.Name = "rightWallSpecularCB";
            this.rightWallSpecularCB.Size = new System.Drawing.Size(64, 17);
            this.rightWallSpecularCB.TabIndex = 0;
            this.rightWallSpecularCB.Text = "Правая";
            this.rightWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // upWallSpecularCB
            // 
            this.upWallSpecularCB.AutoSize = true;
            this.upWallSpecularCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upWallSpecularCB.Location = new System.Drawing.Point(715, 32);
            this.upWallSpecularCB.Margin = new System.Windows.Forms.Padding(6);
            this.upWallSpecularCB.Name = "upWallSpecularCB";
            this.upWallSpecularCB.Size = new System.Drawing.Size(68, 17);
            this.upWallSpecularCB.TabIndex = 0;
            this.upWallSpecularCB.Text = "Верхняя";
            this.upWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // downWallSpecularCB
            // 
            this.downWallSpecularCB.AutoSize = true;
            this.downWallSpecularCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downWallSpecularCB.Location = new System.Drawing.Point(715, 50);
            this.downWallSpecularCB.Margin = new System.Windows.Forms.Padding(6);
            this.downWallSpecularCB.Name = "downWallSpecularCB";
            this.downWallSpecularCB.Size = new System.Drawing.Size(66, 17);
            this.downWallSpecularCB.TabIndex = 0;
            this.downWallSpecularCB.Text = "Нижняя";
            this.downWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(548, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Зеркальность стен";
            // 
            // cubeSpecularCB
            // 
            this.cubeSpecularCB.AutoSize = true;
            this.cubeSpecularCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cubeSpecularCB.Location = new System.Drawing.Point(551, 102);
            this.cubeSpecularCB.Margin = new System.Windows.Forms.Padding(6);
            this.cubeSpecularCB.Name = "cubeSpecularCB";
            this.cubeSpecularCB.Size = new System.Drawing.Size(44, 17);
            this.cubeSpecularCB.TabIndex = 2;
            this.cubeSpecularCB.Text = "Куб";
            this.cubeSpecularCB.UseVisualStyleBackColor = true;
            // 
            // sphereSpecularCB
            // 
            this.sphereSpecularCB.AutoSize = true;
            this.sphereSpecularCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sphereSpecularCB.Location = new System.Drawing.Point(551, 120);
            this.sphereSpecularCB.Margin = new System.Windows.Forms.Padding(6);
            this.sphereSpecularCB.Name = "sphereSpecularCB";
            this.sphereSpecularCB.Size = new System.Drawing.Size(47, 17);
            this.sphereSpecularCB.TabIndex = 2;
            this.sphereSpecularCB.Text = "Шар";
            this.sphereSpecularCB.UseVisualStyleBackColor = true;
            // 
            // refractCubeCB
            // 
            this.refractCubeCB.AutoSize = true;
            this.refractCubeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refractCubeCB.Location = new System.Drawing.Point(685, 102);
            this.refractCubeCB.Margin = new System.Windows.Forms.Padding(6);
            this.refractCubeCB.Name = "refractCubeCB";
            this.refractCubeCB.Size = new System.Drawing.Size(44, 17);
            this.refractCubeCB.TabIndex = 2;
            this.refractCubeCB.Text = "Куб";
            this.refractCubeCB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(548, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Зеркальность фигур";
            // 
            // refractSphereCB
            // 
            this.refractSphereCB.AutoSize = true;
            this.refractSphereCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refractSphereCB.Location = new System.Drawing.Point(685, 123);
            this.refractSphereCB.Margin = new System.Windows.Forms.Padding(6);
            this.refractSphereCB.Name = "refractSphereCB";
            this.refractSphereCB.Size = new System.Drawing.Size(47, 17);
            this.refractSphereCB.TabIndex = 2;
            this.refractSphereCB.Text = "Шар";
            this.refractSphereCB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(682, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Прозрачность фигур";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(548, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Источники света";
            // 
            // lightSource1
            // 
            this.lightSource1.AutoSize = true;
            this.lightSource1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lightSource1.Location = new System.Drawing.Point(551, 174);
            this.lightSource1.Name = "lightSource1";
            this.lightSource1.Size = new System.Drawing.Size(115, 17);
            this.lightSource1.TabIndex = 9;
            this.lightSource1.Text = "Первый источник";
            this.lightSource1.UseVisualStyleBackColor = true;
            // 
            // lightSource2
            // 
            this.lightSource2.AutoSize = true;
            this.lightSource2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lightSource2.Location = new System.Drawing.Point(685, 174);
            this.lightSource2.Name = "lightSource2";
            this.lightSource2.Size = new System.Drawing.Size(111, 17);
            this.lightSource2.TabIndex = 10;
            this.lightSource2.Text = "Второй источник";
            this.lightSource2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 534);
            this.Controls.Add(this.lightSource2);
            this.Controls.Add(this.lightSource1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refractSphereCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refractCubeCB);
            this.Controls.Add(this.sphereSpecularCB);
            this.Controls.Add(this.cubeSpecularCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downWallSpecularCB);
            this.Controls.Add(this.upWallSpecularCB);
            this.Controls.Add(this.rightWallSpecularCB);
            this.Controls.Add(this.leftWallSpecularCB);
            this.Controls.Add(this.backWallSpecularCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frontWallSpecularCB);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ray Tracing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox frontWallSpecularCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox backWallSpecularCB;
        private System.Windows.Forms.CheckBox leftWallSpecularCB;
        private System.Windows.Forms.CheckBox rightWallSpecularCB;
        private System.Windows.Forms.CheckBox upWallSpecularCB;
        private System.Windows.Forms.CheckBox downWallSpecularCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cubeSpecularCB;
        private System.Windows.Forms.CheckBox sphereSpecularCB;
        private System.Windows.Forms.CheckBox refractCubeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox refractSphereCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox lightSource1;
        private System.Windows.Forms.CheckBox lightSource2;
    }
}

