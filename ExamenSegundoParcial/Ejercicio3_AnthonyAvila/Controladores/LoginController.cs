using Ejercicio3_AnthonyAvila.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_AnthonyAvila
{
    class LoginController
    {
        LoginForm vista;
        RegistroForm vistas;

        public LoginController(LoginForm view)
        {
            vista = view;
            
            vista.LoginBTN.Click += new EventHandler(validar);
        }

        public LoginController(RegistroForm views)
        {
            vistas = views;

            vistas.CrearBTN.Click += new EventHandler(Registrar);
        }

        private void validar(object sender, EventArgs e)
        {
            bool valido = false;

            UsuarioDAO DAO = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Correo = vista.UsuarioTBox.Text;
            user.Contrasena = Encriptar(vista.Contra1TBox.Text);

            valido = DAO.valUsuario(user);

            if (valido)
            {
                MenuView menu = new MenuView();
                vista.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }

        private void Registrar(object sender, EventArgs e)
        {
            string confirmar = vistas.CorreoTBox.Text + vistas.label7.Text;
            if (vistas.ConfirmarContra2TBox.Text != vistas.Contra2TBox.Text)
            {
                vistas.errorProvider1.SetError(vistas.ConfirmarContra2TBox, "Contraseñas Diferentes");
                vistas.ConfirmarContra2TBox.Focus();
                return;
            }

            if (vistas.NombreTBox.Text == "")
            {
                vistas.errorProvider1.SetError(vistas.NombreTBox, "Ingrese su nombre");
                vistas.NombreTBox.Focus();
                return;
            }

            if (vistas.ApellidoTBox.Text == "")
            {
                vistas.errorProvider1.SetError(vistas.ApellidoTBox, "Ingrese su apellido");
                vistas.ApellidoTBox.Focus();
                return;
            }

            if (vistas.CorreoTBox.Text == "")
            {
                vistas.errorProvider1.SetError(vistas.CorreoTBox, "Ingrese su Correo");
                vistas.CorreoTBox.Focus();
                return;
            }

            if (vistas.Contra2TBox.Text=="")
            {
                vistas.errorProvider1.SetError(vistas.Contra2TBox, "Ingrese un Contraseña");
                vistas.Contra2TBox.Focus();
                return;
            }

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario usuario = new Usuario();

            usuario.Nombre = vistas.NombreTBox.Text;
            usuario.Apellido = vistas.ApellidoTBox.Text;
            usuario.Correo = confirmar;
            usuario.Contrasena = vistas.Contra2TBox.Text;
            usuario.ConfirmarContrasena = vistas.ConfirmarContra2TBox.Text;

            bool insertar = usuarioDAO.Registrar(usuario);

            if (insertar)
            {
                limpiar();
                MessageBox.Show("Se Registro Existosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
            else
            {
                MessageBox.Show("No se pudo registrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            vistas.NombreTBox.Clear();
            vistas.ApellidoTBox.Clear();
            vistas.CorreoTBox.Clear();
            vistas.Contra2TBox.Clear();
            vistas.ConfirmarContra2TBox.Clear();
        }

        public static string Encriptar(string str)
        { 
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}
