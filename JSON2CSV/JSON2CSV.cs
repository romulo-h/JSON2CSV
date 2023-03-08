using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSON2CSV
{
	public partial class JSON2CSV : Form
	{
		public JSON2CSV()
		{
			InitializeComponent();
			txbCSV.ReadOnly = true;
			lblErro.Visible = false;
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			txbJSON.Text = string.Empty;
			txbCSV.Text = string.Empty;
			lblErro.Visible = false;
		}

		private void btnConverter_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txbJSON.Text))
			{				
				try
				{
					JArray objJson= JArray.Parse(txbJSON.Text);

					string temp = Path.GetTempFileName();
					using (StreamWriter writer = new StreamWriter(temp))
					{
						JToken firstObject = objJson.First;
						foreach (JProperty property in firstObject)
						{
							writer.Write($"{property.Name},");
						}
						writer.WriteLine();

						foreach (JToken token in objJson)
						{
							foreach (JProperty property in token)
							{
								writer.Write($"{property.Value},");
							}
							writer.WriteLine();
						}
					}

					string csvText = File.ReadAllText(temp);
					txbCSV.Text = csvText;

					File.Delete(temp);

				}
				catch (Exception ex)
				{
					lblErro.Visible = true;
					lblErro.Text = "JSON inválido!" + ex.Message;
				}

			}
			else
			{
				lblErro.Visible = true;
				lblErro.Text = "Favor adicionar o texto JSON!";
			}
		}
	}
}

