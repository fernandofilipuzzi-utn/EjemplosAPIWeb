using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientAPIWebDesktop
{
    /// <summary>
    /// Ejemplo sencillo GET http
    /// </summary>
public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    async private void button1_Click(object sender, EventArgs e)
    {
        string baseUrl = "https://localhost:44330/api/Ejemplo";

        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/5");

                string url = $"{baseUrl}/5?valor={Uri.EscapeDataString(textBox1.Text)}&token={"1"}";
                request.RequestUri = new Uri(url);

                HttpResponseMessage response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    textBox2.Text = "Respuesta de la API: " + content;
                }
                else
                {
                    textBox2.Text="Error en la solicitud: " + response.StatusCode;
                }
            }
            catch (Exception ex)
            {
                textBox2.Text = "Error: " + ex.Message;
            }
        }
    }
}
}
