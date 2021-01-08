using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-VNLAPUO\SQLEXPRESS;Database=CADASTRO;Integrated Security=true;");

                strSQL = "INSERT INTO Pessoa (NOME, SOBRENOME) VALUES (@NOME, @SOBRENOME)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", nometxt.Text);

                comando.Parameters.AddWithValue("@SOBRENOME", sobrenometxt.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-VNLAPUO\SQLEXPRESS;Database=CADASTRO;Integrated Security=true;");

                strSQL = "select * from Pessoa";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                
                conexao = null;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-VNLAPUO\SQLEXPRESS;Database=CADASTRO;Integrated Security=true;");

                strSQL = "select * from Pessoa where id = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtID.Text);

                

                conexao.Open();

                dr = comando.ExecuteReader();


                while (dr.Read())
                {
                    nometxt.Text = (string)dr["NOME"];
                    sobrenometxt.Text = (string)dr["SOBRENOME"];
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-VNLAPUO\SQLEXPRESS;Database=CADASTRO;Integrated Security=true;");

                strSQL = "UPDATE Pessoa SET NOME = @NOME , SOBRENOME = @SOBRENOME WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtID.Text);

                comando.Parameters.AddWithValue("@NOME", nometxt.Text);

                comando.Parameters.AddWithValue("@SOBRENOME", sobrenometxt.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-VNLAPUO\SQLEXPRESS;Database=CADASTRO;Integrated Security=true;");

                strSQL = "DELETE Pessoa  WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtID.Text);

                

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }
    }
    
}
