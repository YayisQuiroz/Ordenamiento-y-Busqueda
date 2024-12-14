using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppOrdenamientoYbusqueda;

namespace AppOrdenamientoYbusqueda
{
    public partial class Form1 : Form
    {
        private List<Persona> personas;

        public Form1()
        {
            InitializeComponent();
            personas = new List<Persona>
            {
                new Persona("Juan", "Perez", 1, 22, "Ingenieria en Sistemas"),
                new Persona("Ana", "Gonzalez", 2, 24, "Arquitectura"),
                new Persona("Carlos", "Rodriguez", 3, 21, "Medicina")
            };
        }

        private void MostrarPersonas()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personas;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPersonas();
        }
        private void BubbleSortPorNombre()
        {
            for (int i = 0; i < personas.Count - 1; i++)
            {
                for (int j = 0; j < personas.Count - 1 - i; j++)
                {
                    if (string.Compare(personas[j].Nombre, personas[j + 1].Nombre, StringComparison.Ordinal) > 0)
                    {
                        var temp = personas[j];
                        personas[j] = personas[j + 1];
                        personas[j + 1] = temp;
                    }
                }
            }
            MostrarPersonas();
        }
        private void SelectionSortPorApellido()
        {
            for (int i = 0; i < personas.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < personas.Count; j++)
                {
                    if (string.Compare(personas[j].Apellido, personas[minIndex].Apellido, StringComparison.Ordinal) < 0)
                    {
                        minIndex = j;
                    }
                }
                var temp = personas[i];
                personas[i] = personas[minIndex];
                personas[minIndex] = temp;
            }
            MostrarPersonas();
        }
        private void InsertionSortPorID()
        {
            for (int i = 1; i < personas.Count; i++)
            {
                var key = personas[i];
                int j = i - 1;
                while (j >= 0 && personas[j].Id > key.Id)
                {
                    personas[j + 1] = personas[j];
                    j--;
                }
                personas[j + 1] = key;
            }
            MostrarPersonas();
        }
        private void QuickSortPorEdad(int low, int high)
        {
            if (low < high)
            {
                int pi = PartitionPorEdad(low, high);
                QuickSortPorEdad(low, pi - 1);
                QuickSortPorEdad(pi + 1, high);
            }
        }
        private int PartitionPorEdad(int low, int high)
        {
            int pivot = personas[high].Edad;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (personas[j].Edad < pivot)
                {
                    i++;
                    (personas[i], personas[j]) = (personas[j], personas[i]);
                }
            }

            (personas[i + 1], personas[high]) = (personas[high], personas[i + 1]);
            return i + 1;
        }
        private void ShellSortPorNombre()
        {
            int n = personas.Count;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    var temp = personas[i];
                    int j;
                    for (j = i; j >= gap && string.Compare(personas[j - gap].Nombre, temp.Nombre, StringComparison.Ordinal) > 0; j -= gap)
                    {
                        personas[j] = personas[j - gap];
                    }
                    personas[j] = temp;
                }
            }
            MostrarPersonas();
        }
        private void RadixSortPorID()
        {
            int maxId = personas.Max(p => p.Id);
            int exp = 1;
            while (maxId / exp > 0)
            {
                CountSortPorID(exp);
                exp *= 10;
            }
            MostrarPersonas();
        }
        private void CountSortPorID(int exp)
        {
            int n = personas.Count;
            var output = new List<Persona>(new Persona[n]);
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
                count[(personas[i].Id / exp) % 10]++;

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                int index = (personas[i].Id / exp) % 10;
                output[count[index] - 1] = personas[i];
                count[index]--;
            }

            for (int i = 0; i < n; i++)
                personas[i] = output[i];
        }
        private void HeapSortPorEdad()
        {
            int n = personas.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
                HeapifyPorEdad(n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                (personas[0], personas[i]) = (personas[i], personas[0]);
                HeapifyPorEdad(i, 0);
            }

            MostrarPersonas();
        }
        private void HeapifyPorEdad(int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && personas[left].Edad > personas[largest].Edad)
                largest = left;

            if (right < n && personas[right].Edad > personas[largest].Edad)
                largest = right;

            if (largest != i)
            {
                (personas[i], personas[largest]) = (personas[largest], personas[i]);
                HeapifyPorEdad(n, largest);
            }
        }
        private void MergeSortPorCarrera(int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSortPorCarrera(left, middle);
                MergeSortPorCarrera(middle + 1, right);
                MergePorCarrera(left, middle, right);
            }
        }
        private void MergePorCarrera(int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            var leftArray = new List<Persona>(n1);
            var rightArray = new List<Persona>(n2);

            for (int i = 0; i < n1; i++)
                leftArray.Add(personas[left + i]);

            for (int j = 0; j < n2; j++)
                rightArray.Add(personas[middle + 1 + j]);

            int k = left, iIndex = 0, jIndex = 0;

            while (iIndex < n1 && jIndex < n2)
            {
                if (string.Compare(leftArray[iIndex].Carrera, rightArray[jIndex].Carrera, StringComparison.Ordinal) <= 0)
                {
                    personas[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    personas[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
            {
                personas[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }

            while (jIndex < n2)
            {
                personas[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }
        }
        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            MergeSortPorCarrera(0, personas.Count - 1);
            MostrarPersonas();
        }
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSortPorNombre();
        }
        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            SelectionSortPorApellido();
        }
        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            InsertionSortPorID();
        }
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            QuickSortPorEdad(0, personas.Count - 1);
            MostrarPersonas();
        }
        private void btnShellSort_Click(object sender, EventArgs e)
        {
            ShellSortPorNombre();
        }
        private void btnRadixSort_Click(object sender, EventArgs e)
        {
            RadixSortPorID();
        }
        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            RadixSortPorID();//heapSort necesita la lista acomodada por eso utilizo otro metodo de apoyo
            HeapSortPorEdad();
        }
        private void btnBusquedaSecuencial_Click(object sender, EventArgs e)
        {
            string criterio = txtBusqueda.Text.ToLower();
            var resultado = personas.FirstOrDefault(p => p.Nombre.ToLower() == criterio);

            if (resultado != null)
                MessageBox.Show($"Resultado: {resultado.Nombre} {resultado.Apellido}, Id: {resultado.Id}, Carrera: {resultado.Carrera}, Edad: {resultado.Edad}");
            else
                MessageBox.Show("No se encontró el elemento.");
        }
        private void btnBusquedaBinaria_Click(object sender, EventArgs e)
        {
            personas = personas.OrderBy(p => p.Apellido).ToList();
            string criterio = txtBusqueda.Text.ToLower();
            int inicio = 0, fin = personas.Count - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                int comparacion = string.Compare(personas[medio].Apellido.ToLower(), criterio);

                if (comparacion == 0)
                {
                    MessageBox.Show($"Resultado: {personas[medio].Nombre} {personas[medio].Apellido}, ID: {personas[medio].Id}, Carrera: {personas[medio].Carrera}, Edad: {personas[medio].Edad}");
                    return;
                }
                else if (comparacion < 0)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            MessageBox.Show("No se encontró el elemento.");
        }
        private void btnBusquedaExponencial_Click(object sender, EventArgs e)
        {
            personas = personas.OrderBy(p => p.Nombre).ToList();
            string criterio = txtBusqueda.Text.ToLower();
            int n = personas.Count;

            if (n == 0)
            {
                MessageBox.Show("La lista está vacía.");
                return;
            }

            if (personas[0].Nombre.ToLower() == criterio)
            {
                MessageBox.Show($"Resultado: {personas[0].Nombre} {personas[0].Apellido}, ID: {personas[0].Id}, Carrera: {personas[0].Carrera}, Edad: {personas[0].Edad}");
                return;
            }

            int rango = 1;
            while (rango < n && personas[rango].Nombre.ToLower().CompareTo(criterio) <= 0)
                rango *= 2;

            int inicio = rango / 2;
            int fin = Math.Min(rango, n);
            for (int i = inicio; i < fin; i++)
            {
                if (personas[i].Nombre.ToLower() == criterio)
                {
                    MessageBox.Show($"Resultado: {personas[i].Nombre} {personas[i].Apellido}, ID: {personas[i].Id}, Carrera: {personas[0].Carrera}, Edad: {personas[0].Edad}");
                    return;
                }
            }

            MessageBox.Show("No se encontró el elemento.");
        }
        private void btnJumpSearch_Click(object sender, EventArgs e)
        {
            personas = personas.OrderBy(p => p.Carrera).ToList();
            string criterio = txtBusqueda.Text.ToLower();

            int n = personas.Count;
            int paso = (int)Math.Sqrt(n);
            int prev = 0;

            while (personas[Math.Min(paso, n) - 1].Carrera.ToLower().CompareTo(criterio) < 0)
            {
                prev = paso;
                paso += (int)Math.Sqrt(n);
                if (prev >= n)
                {
                    MessageBox.Show("No se encontró el elemento.");
                    return;
                }
            }

            for (int i = prev; i < Math.Min(paso, n); i++)
            {
                if (personas[i].Carrera.ToLower() == criterio)
                {
                    MessageBox.Show($"Resultado: {personas[i].Nombre} {personas[i].Apellido}, Carrera: {personas[i].Carrera}, ID: {personas[i].Id}, Edad: {personas[i]}");
                    return;
                }
            }
            MessageBox.Show("No se encontró el elemento.");
        }
        private void btnBusquedaInterpolacion_Click(object sender, EventArgs e)
        {
            personas = personas.OrderBy(p => p.Edad).ToList();
            if (!int.TryParse(txtBusqueda.Text, out int edadCriterio))
            {
                MessageBox.Show("Por favor, ingrese una edad válida.");
                return;
            }

            int low = 0, high = personas.Count - 1;
            while (low <= high && edadCriterio >= personas[low].Edad && edadCriterio <= personas[high].Edad)
            {
                if (low == high)
                {
                    if (personas[low].Edad == edadCriterio)
                    {
                        MessageBox.Show($"Resultado: {personas[low].Nombre} {personas[low].Apellido}, Edad: {personas[low].Edad}, Carrera: {personas[low].Carrera}, Id: {personas[low].Id}");
                        return;
                    }
                    break;
                }

                int pos = low + ((edadCriterio - personas[low].Edad) * (high - low) / (personas[high].Edad - personas[low].Edad));

                if (personas[pos].Edad == edadCriterio)
                {
                    MessageBox.Show($"Resultado: {personas[pos].Nombre} {personas[pos].Apellido}, Edad: {personas[pos].Edad}, Carrera: {personas[low].Carrera}, Id: {personas[low].Id}");
                    return;
                }

                if (personas[pos].Edad < edadCriterio)
                    low = pos + 1;
                else
                    high = pos - 1;
            }
            MessageBox.Show("No se encontró el elemento.");
        }
        private void btnBusquedaFibonacci_Click(object sender, EventArgs e)
        {
            personas = personas.OrderBy(p => p.Edad).ToList();
            if (!int.TryParse(txtBusqueda.Text, out int edadCriterio))
            {
                MessageBox.Show("Por favor, ingrese una edad válida.");
                return;
            }

            int n = personas.Count;
            int fibM2 = 0;
            int fibM1 = 1;
            int fibM = fibM2 + fibM1;

            while (fibM < n)
            {
                fibM2 = fibM1;
                fibM1 = fibM;
                fibM = fibM2 + fibM1;
            }

            int offset = -1;

            while (fibM > 1)
            {
                int i = Math.Min(offset + fibM2, n - 1);

                if (personas[i].Edad < edadCriterio)
                {
                    fibM = fibM1;
                    fibM1 = fibM2;
                    fibM2 = fibM - fibM1;
                    offset = i;
                }
                else if (personas[i].Edad > edadCriterio)
                {
                    fibM = fibM2;
                    fibM1 -= fibM2;
                    fibM2 = fibM - fibM1;
                }
                else
                {
                    MessageBox.Show($"Resultado: {personas[i].Nombre} {personas[i].Apellido}, Edad: {personas[i].Edad}, ID: {personas[i].Id}, Carrera: {personas[i].Carrera}");
                    return;
                }
            }

            if (fibM1 == 1 && offset + 1 < n && personas[offset + 1].Edad == edadCriterio)
            {
                MessageBox.Show($"Resultado: {personas[offset + 1].Nombre} {personas[offset + 1].Apellido}, Edad: {personas[offset + 1].Edad} Carrera: {personas[offset + 1].Carrera}, ID: {personas[offset + 1].Id}");
                return;
            }

            MessageBox.Show("No se encontró el elemento.");
        }
        private void btnBusquedaHashing_Click(object sender, EventArgs e)
        {
            var hashTable = new Dictionary<int, Persona>();
            foreach (var persona in personas)
            {
                hashTable[persona.Id] = persona;
            }

            if (!int.TryParse(txtBusqueda.Text, out int idCriterio))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                return;
            }

            if (hashTable.TryGetValue(idCriterio, out Persona resultado))
            {
                MessageBox.Show($"Resultado: {resultado.Nombre} {resultado.Apellido}, ID: {resultado.Id}, Carrera: {resultado.Carrera}, Edad: {resultado.Edad}");
            }
            else
            {
                MessageBox.Show("No se encontró el elemento.");
            }
        }
        private void btnBusquedaRecursiva_Click(object sender, EventArgs e)
        {
            personas = personas.OrderBy(p => p.Id).ToList();
            if (!int.TryParse(txtBusqueda.Text, out int idCriterio))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                return;
            }

            int resultado = BusquedaRecursivaID(personas, 0, personas.Count - 1, idCriterio);
            if (resultado != -1)
            {
                var persona = personas[resultado];
                MessageBox.Show($"Resultado: {persona.Nombre} {persona.Apellido}, ID: {persona.Id}, Carrera: {persona.Carrera}, Edad: {persona.Edad}");
            }
            else
            {
                MessageBox.Show("No se encontró el elemento.");
            }

        }
        private int BusquedaRecursivaID(List<Persona> lista, int inicio, int fin, int id)
        {
            if (inicio > fin) return -1;

            int medio = (inicio + fin) / 2;

            if (lista[medio].Id == id)
                return medio;

            if (lista[medio].Id < id)
                return BusquedaRecursivaID(lista, medio + 1, fin, id);
            else
                return BusquedaRecursivaID(lista, inicio, medio - 1, id);
        }
    }
}
