﻿namespace salesForm_ex
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.saleList = new System.Windows.Forms.ListView();
            this.txtAnalysis = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCustomerSales = new System.Windows.Forms.Button();
            this.btnItemSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(84, 27);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(136, 25);
            this.txtCustomer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "고객명 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "제품명 :";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(305, 24);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(136, 25);
            this.txtItem.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "판매 날짜";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(84, 74);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 25);
            this.dtDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "판매 개수 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "판매 금액 :";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(430, 80);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(72, 25);
            this.txtQty.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(656, 77);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(72, 25);
            this.txtPrice.TabIndex = 9;
            // 
            // saleList
            // 
            this.saleList.HideSelection = false;
            this.saleList.Location = new System.Drawing.Point(12, 123);
            this.saleList.Name = "saleList";
            this.saleList.Size = new System.Drawing.Size(658, 164);
            this.saleList.TabIndex = 10;
            this.saleList.UseCompatibleStateImageBehavior = false;
            // 
            // txtAnalysis
            // 
            this.txtAnalysis.Location = new System.Drawing.Point(12, 293);
            this.txtAnalysis.Multiline = true;
            this.txtAnalysis.Name = "txtAnalysis";
            this.txtAnalysis.Size = new System.Drawing.Size(658, 145);
            this.txtAnalysis.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(704, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "매출 등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(704, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "매출 삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCustomerSales
            // 
            this.btnCustomerSales.Location = new System.Drawing.Point(676, 311);
            this.btnCustomerSales.Name = "btnCustomerSales";
            this.btnCustomerSales.Size = new System.Drawing.Size(120, 43);
            this.btnCustomerSales.TabIndex = 14;
            this.btnCustomerSales.Text = "고객별 판매금액 분석";
            this.btnCustomerSales.UseVisualStyleBackColor = true;
            // 
            // btnItemSales
            // 
            this.btnItemSales.Location = new System.Drawing.Point(676, 375);
            this.btnItemSales.Name = "btnItemSales";
            this.btnItemSales.Size = new System.Drawing.Size(120, 47);
            this.btnItemSales.TabIndex = 15;
            this.btnItemSales.Text = "제품별 판매금액 분석";
            this.btnItemSales.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnItemSales);
            this.Controls.Add(this.btnCustomerSales);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAnalysis);
            this.Controls.Add(this.saleList);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListView saleList;
        private System.Windows.Forms.TextBox txtAnalysis;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCustomerSales;
        private System.Windows.Forms.Button btnItemSales;
    }
}
