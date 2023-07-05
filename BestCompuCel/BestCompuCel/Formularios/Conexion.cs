using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BestCompuCel.Formularios
{
    internal class Conexion
    {
        //Atributos de clase
        private int _id_folio;
        private string _nombre;
        private int _celular;
        private int _telefono;
        private string _equipo;
        private string _marca;
        private string _modelo;
        private string _serie;
        private string _estado;
        private string _falla;
        private string _accesorios;
        private float _costo;
        private string _clave;
        private string _fecha;
        private string _hora;
        private string _entregado;
        private string _comentarios;

        public int id_folio { get => _id_folio; set => _id_folio = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public int celular { get => _celular; set => _celular = value; }
        public int telefono { get => _telefono; set => _telefono = value; }
        public string equipo { get => _equipo; set => _equipo = value; }
        public string marca { get => _marca; set => _marca = value; }
        public string modelo { get => _modelo; set => _modelo = value; }
        public string serie { get => _serie; set => _serie = value; }
        public string estado { get => _estado; set => _estado = value; }
        public string falla { get => _falla; set => _falla = value; }
        public string accesorios { get => _accesorios; set => _accesorios = value; }
        public float costo { get => _costo; set => _costo = value; }
        public string clave { get => _clave; set => _clave = value; }
        public string fecha { get => _fecha; set => _fecha = value; }
        public string hora { get => _hora; set => _hora = value; }
        public string entregado { get => _entregado; set => _entregado = value; }
        public string comentarios { get => _comentarios; set => _comentarios = value; }

        public Conexion(int id_folio, string nombre, int celular, int telefono, string equipo, string marca, string modelo, string serie, string estado, string falla, string accesorios, float costo, string clave, string fecha, string hora, string entregado, string comentarios)
        {
            _id_folio = id_folio;
            _nombre = nombre;
            _celular = celular;
            _telefono = telefono;
            _equipo = equipo;
            _marca = marca;
            _modelo = modelo;
            _serie = serie;
            _estado = estado;
            _falla = falla;
            _accesorios = accesorios;
            _costo = costo;
            _clave = clave;
            _fecha = fecha;
            _hora = hora;
            _entregado = entregado;
            _comentarios = comentarios;
        }

        public static void Registrar(Conexion a) {
            SqlConnection cn = new SqlConnection("Server=127.0.0.1;Port=3306;Database=best_compu_cell;Uid=;Pwd=;");
            cn.Open();
            string query = $"INSERT INTO NombreTabla (id_folio, nombre, celular, telefono, equipo, marca, modelo, serie, estado, falla, accesorios, costo, clave, fecha, hora, entregado, comentarios) " +
               $"VALUES ({a.id_folio}, '{a.nombre}', {a.celular}, {a.telefono}, '{a.equipo}', '{a.marca}', '{a.modelo}', '{a.serie}', '{a.estado}', '{a.falla}', '{a.accesorios}', {a.costo}, '{a.clave}', '{a.fecha}', '{a.hora}', '{a.entregado}', '{a.comentarios}')";
            Console.WriteLine(query);

            try
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {

                throw new Exception("Error al registrar el equipo:" + (e.Message));
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
