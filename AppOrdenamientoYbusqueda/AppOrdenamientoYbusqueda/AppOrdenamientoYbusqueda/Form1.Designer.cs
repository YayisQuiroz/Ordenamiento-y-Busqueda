using System;

namespace AppOrdenamientoYbusqueda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnRadixSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.lblBubble = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBusquedaSecuencial = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBusquedaBinaria = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBusquedaExponencial = new System.Windows.Forms.Button();
            this.btnJumpSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBusquedaInterpolacion = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBusquedaFibonacci = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBusquedaHashing = new System.Windows.Forms.Button();
            this.btnBusquedaRecursiva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(291, 346);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(91, 36);
            this.btnBubbleSort.TabIndex = 1;
            this.btnBubbleSort.Text = "BubbleSort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(673, 402);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(104, 28);
            this.btnSelectionSort.TabIndex = 2;
            this.btnSelectionSort.Text = "SelectionSort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(555, 347);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(95, 35);
            this.btnInsertionSort.TabIndex = 3;
            this.btnInsertionSort.Text = "InsertionSort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(430, 389);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(99, 41);
            this.btnQuickSort.TabIndex = 4;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(673, 343);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(104, 39);
            this.btnMergeSort.TabIndex = 5;
            this.btnMergeSort.Text = "MergeSort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Location = new System.Drawing.Point(428, 346);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(101, 36);
            this.btnHeapSort.TabIndex = 6;
            this.btnHeapSort.Text = " HeapSort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnRadixSort
            // 
            this.btnRadixSort.Location = new System.Drawing.Point(555, 388);
            this.btnRadixSort.Name = "btnRadixSort";
            this.btnRadixSort.Size = new System.Drawing.Size(95, 42);
            this.btnRadixSort.TabIndex = 7;
            this.btnRadixSort.Text = "RadixSort";
            this.btnRadixSort.UseVisualStyleBackColor = true;
            this.btnRadixSort.Click += new System.EventHandler(this.btnRadixSort_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Location = new System.Drawing.Point(291, 388);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(91, 42);
            this.btnShellSort.TabIndex = 8;
            this.btnShellSort.Text = "ShellSort";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);
            // 
            // lblBubble
            // 
            this.lblBubble.AutoSize = true;
            this.lblBubble.Location = new System.Drawing.Point(552, 324);
            this.lblBubble.Name = "lblBubble";
            this.lblBubble.Size = new System.Drawing.Size(91, 16);
            this.lblBubble.TabIndex = 9;
            this.lblBubble.Text = "Ordena por ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ordena por Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ordena por Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ordena por Carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ordena por edad";
            // 
            // btnBusquedaSecuencial
            // 
            this.btnBusquedaSecuencial.Location = new System.Drawing.Point(15, 110);
            this.btnBusquedaSecuencial.Name = "btnBusquedaSecuencial";
            this.btnBusquedaSecuencial.Size = new System.Drawing.Size(109, 35);
            this.btnBusquedaSecuencial.TabIndex = 20;
            this.btnBusquedaSecuencial.Text = "Secuencial";
            this.btnBusquedaSecuencial.UseVisualStyleBackColor = true;
            this.btnBusquedaSecuencial.Click += new System.EventHandler(this.btnBusquedaSecuencial_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(143, 43);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 22);
            this.txtBusqueda.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Criterio de Busqueda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Busqueda por nombre";
            // 
            // btnBusquedaBinaria
            // 
            this.btnBusquedaBinaria.Location = new System.Drawing.Point(12, 290);
            this.btnBusquedaBinaria.Name = "btnBusquedaBinaria";
            this.btnBusquedaBinaria.Size = new System.Drawing.Size(112, 35);
            this.btnBusquedaBinaria.TabIndex = 24;
            this.btnBusquedaBinaria.Text = "Binaria";
            this.btnBusquedaBinaria.UseVisualStyleBackColor = true;
            this.btnBusquedaBinaria.Click += new System.EventHandler(this.btnBusquedaBinaria_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Busqueda por Apellido";
            // 
            // btnBusquedaExponencial
            // 
            this.btnBusquedaExponencial.Location = new System.Drawing.Point(130, 110);
            this.btnBusquedaExponencial.Name = "btnBusquedaExponencial";
            this.btnBusquedaExponencial.Size = new System.Drawing.Size(112, 35);
            this.btnBusquedaExponencial.TabIndex = 26;
            this.btnBusquedaExponencial.Text = "Exponencial";
            this.btnBusquedaExponencial.UseVisualStyleBackColor = true;
            this.btnBusquedaExponencial.Click += new System.EventHandler(this.btnBusquedaExponencial_Click);
            // 
            // btnJumpSearch
            // 
            this.btnJumpSearch.Location = new System.Drawing.Point(12, 347);
            this.btnJumpSearch.Name = "btnJumpSearch";
            this.btnJumpSearch.Size = new System.Drawing.Size(112, 35);
            this.btnJumpSearch.TabIndex = 27;
            this.btnJumpSearch.Text = "JumpSearch";
            this.btnJumpSearch.UseVisualStyleBackColor = true;
            this.btnJumpSearch.Click += new System.EventHandler(this.btnJumpSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Busqueda por Carrera";
            // 
            // btnBusquedaInterpolacion
            // 
            this.btnBusquedaInterpolacion.Location = new System.Drawing.Point(130, 171);
            this.btnBusquedaInterpolacion.Name = "btnBusquedaInterpolacion";
            this.btnBusquedaInterpolacion.Size = new System.Drawing.Size(112, 38);
            this.btnBusquedaInterpolacion.TabIndex = 29;
            this.btnBusquedaInterpolacion.Text = "Interpolacion";
            this.btnBusquedaInterpolacion.UseVisualStyleBackColor = true;
            this.btnBusquedaInterpolacion.Click += new System.EventHandler(this.btnBusquedaInterpolacion_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Busqueda por Edad";
            // 
            // btnBusquedaFibonacci
            // 
            this.btnBusquedaFibonacci.Location = new System.Drawing.Point(12, 171);
            this.btnBusquedaFibonacci.Name = "btnBusquedaFibonacci";
            this.btnBusquedaFibonacci.Size = new System.Drawing.Size(112, 38);
            this.btnBusquedaFibonacci.TabIndex = 31;
            this.btnBusquedaFibonacci.Text = "Fibonacci";
            this.btnBusquedaFibonacci.UseVisualStyleBackColor = true;
            this.btnBusquedaFibonacci.Click += new System.EventHandler(this.btnBusquedaFibonacci_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Busqueda por Id";
            // 
            // btnBusquedaHashing
            // 
            this.btnBusquedaHashing.Location = new System.Drawing.Point(12, 231);
            this.btnBusquedaHashing.Name = "btnBusquedaHashing";
            this.btnBusquedaHashing.Size = new System.Drawing.Size(112, 38);
            this.btnBusquedaHashing.TabIndex = 33;
            this.btnBusquedaHashing.Text = "Hashing";
            this.btnBusquedaHashing.UseVisualStyleBackColor = true;
            this.btnBusquedaHashing.Click += new System.EventHandler(this.btnBusquedaHashing_Click);
            // 
            // btnBusquedaRecursiva
            // 
            this.btnBusquedaRecursiva.Location = new System.Drawing.Point(130, 231);
            this.btnBusquedaRecursiva.Name = "btnBusquedaRecursiva";
            this.btnBusquedaRecursiva.Size = new System.Drawing.Size(112, 38);
            this.btnBusquedaRecursiva.TabIndex = 34;
            this.btnBusquedaRecursiva.Text = "Recursiva";
            this.btnBusquedaRecursiva.UseVisualStyleBackColor = true;
            this.btnBusquedaRecursiva.Click += new System.EventHandler(this.btnBusquedaRecursiva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 471);
            this.Controls.Add(this.btnBusquedaRecursiva);
            this.Controls.Add(this.btnBusquedaHashing);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnBusquedaFibonacci);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBusquedaInterpolacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnJumpSearch);
            this.Controls.Add(this.btnBusquedaExponencial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBusquedaBinaria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBusquedaSecuencial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBubble);
            this.Controls.Add(this.btnShellSort);
            this.Controls.Add(this.btnRadixSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnRadixSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Label lblBubble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusquedaSecuencial;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBusquedaBinaria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBusquedaExponencial;
        private System.Windows.Forms.Button btnJumpSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBusquedaInterpolacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBusquedaFibonacci;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBusquedaHashing;
        private System.Windows.Forms.Button btnBusquedaRecursiva;
    }
}