using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using TopSecretLibrary;

namespace TopSecret
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try{
                if (File.Exists(txtFile.Text)){
                 
                    StreamReader r = new StreamReader(txtFile.Text);
                    string json = r.ReadToEnd();
                    List<Satellite> listSat = JsonConvert.DeserializeObject<List<Satellite>>(json);

                    if (listSat!= null && listSat.Count == 3){
                        txtOut.Text = "";

                        string x, y;

                        x = ConfigurationManager.AppSettings["kenobix"];
                        y = ConfigurationManager.AppSettings["kenobiy"];
                        Position posA = new Position(Convert.ToDouble(x), Convert.ToDouble(y));

                        x = ConfigurationManager.AppSettings["skywalkerx"];
                        y = ConfigurationManager.AppSettings["skywalkery"];
                        Position posB = new Position(Convert.ToDouble(x), Convert.ToDouble(y));

                        x = ConfigurationManager.AppSettings["satox"];
                        y = ConfigurationManager.AppSettings["satoy"];
                        Position posC = new Position(Convert.ToDouble(x), Convert.ToDouble(y));

                        TopSecretLibrary.TopSecret objTS = new TopSecretLibrary.TopSecret(posA, posB, posC);

                        Position posSpaceship = objTS.GetLocation(listSat[0].distance, listSat[1].distance, listSat[2].distance);
                        if (posSpaceship != null){
                            string message = objTS.GetMessage(listSat[0].message, listSat[1].message, listSat[2].message);

                            if (message != ""){
                                txtOut.Text = "Información de los satelites:\r\n\r\n";
                                txtOut.Text += "Nombre: " + listSat[0].name + "\r\n";
                                txtOut.Text += "Distancia: " + listSat[0].distance + "\r\n\r\n";
                                txtOut.Text += "Nombre: " + listSat[1].name + "\r\n";
                                txtOut.Text += "Distancia: " + listSat[1].distance + "\r\n\r\n";
                                txtOut.Text += "Nombre: " + listSat[2].name + "\r\n";
                                txtOut.Text += "Distancia: " + listSat[2].distance + "\r\n\r\n";

                                txtOut.Text += "Mensaje detectado: " + message + "\r\n\r\n";
                                txtOut.Text += "Coordenadas de la nave emisora: (" + posSpaceship.X + "," + posSpaceship.Y + ")";
                            }
                            else
                                MessageBox.Show(this, "No se pudo descifrar el mensaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show(this, "No se pudo determinar la posición de la nave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                        MessageBox.Show(this, "La información del archivo es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    if (txtFile.Text.Trim() == "") 
                        MessageBox.Show(this, "Debe seleccionar un archivo json con la información de los satelites", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(this, "No se encontró el archivo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try{
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "Json files (*.json)|*.json";
                if (fd.ShowDialog() == DialogResult.OK)
                    txtFile.Text = fd.FileName;
            }
            catch (Exception ex){
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
