using System.Collections;
using Ejercicio1.Models;


namespace Ejercicio1;

public partial class Form1 : Form
{

    //ArrayList figuras = new ArrayList();
    List<Figura> figuras = new List<Figura>();


    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        //un ortoedro es una figura pero una figura no sabes si es o no, necesiriamente un ortoedro.

        Figura nueva = null;

        if (radioButton1.Checked == true)
        {
            nueva = new Ortoedro(1, 1, 1);
        }
        else if (radioButton2.Checked == true)
        {
            nueva = new Cilindro(1, 1);
        }

        if (nueva != null) //Verifico si selecciono un tipo de figura
        {
            figuras.Add(nueva);
        }
        else
        {
            MessageBox.Show("Debe seleccionar un tipo de figura");
        }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        lbMostrar.Items.Clear();
        foreach (Figura f in figuras)
        {
            lbMostrar.Items.Add(f);
        }


    }

    private void button2_Click(object sender, EventArgs e)
    {
        Figura Seleccionada = lbMostrar.SelectedItem as Figura; //primer casteo

        label1.Text = "";
        if (Seleccionada != null)
        {
            if (Seleccionada is Ortoedro)
            {
                Ortoedro aux = (Ortoedro)Seleccionada; //casteo duro
                label1.Text = $"Ancho: {aux.Ancho:f2} x Alto: {aux.Alto:f2} \n"; //accede a los parametros

            }
            else if (Seleccionada is Cilindro)
            {
                Cilindro aux = (Cilindro)Seleccionada;
                label1.Text = $"Radio: {aux.Radio:f2}\n";
            }
            label1.Text += Seleccionada.Describrir();

        }
        else
            label1.Text = "No ha seleccionado ninguna figura";

    }

    private void button3_Click(object sender, EventArgs e)
    {
        
        figuras.Sort(); //internamente sale al i comparable
    }
}
