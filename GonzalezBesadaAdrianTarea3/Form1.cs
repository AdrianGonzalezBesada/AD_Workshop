using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib.Extensions;

namespace GonzalezBesadaAdrianTarea3
{
    public partial class Form1 : Form
    {
        string _connectionString = "Initial Catalog = Pokemon; Data Source = localhost; Integrated Security = SSPI";
        SqlConnection _conexion = null;

        List<Pokemon> _listaPokemons = new List<Pokemon>();
        List<Pokemon> _listaPokemonsFiltrada = new List<Pokemon>();

        public Form1()
        {
            InitializeComponent();
            CargarListaPokemons();
            CargarComboTipos();
        }

        #region Database

        private SqlConnection IniciarConexion()
        {
            _conexion = new SqlConnection(_connectionString);
            _conexion.Open();
            return _conexion;
        }

        private List<Pokemon> GetAllPokemon()
        {
            using (IniciarConexion())
            {
                return (List<Pokemon>)_conexion.GetAll<Pokemon>();
            }
        }

        private Pokemon GetPokemonById(int pokemonId)
        {
            string consulta = $"SELECT p.*, eb.ps, eb.ataque, eb.defensa, eb.especial, eb.especial FROM pokemon AS p INNER JOIN estadisticas_base AS eb ON eb.PokemonId = p.PokemonId WHERE p.PokemonId = {pokemonId}";
            using (IniciarConexion())
            {
                return (Pokemon)_conexion.Query<Pokemon>(consulta).FirstOrDefault();
            }
        }

        private List<Tipo> GetAllTipos()
        {
            using (IniciarConexion())
            {
                return (List<Tipo>)_conexion.GetAll<Tipo>();
            }
        }

        private List<Tipo> GetTiposByIdPokemon(Pokemon pokemon)
        {
            string consulta = "SELECT t.* FROM pokemon as p INNER JOIN pokemon_tipo AS pt ON pt.PokemonId = p.PokemonId INNER JOIN tipo as t ON t.id_tipo = pt.id_tipo WHERE p.PokemonId = @pokemonId";

            using (IniciarConexion())
            {
                return (List<Tipo>)_conexion.Query<Tipo>(consulta, pokemon);
            }
        }

        private List<Movimiento> GetMovimientos(Pokemon pokemon)
        {
            string consulta = "SELECT m.* FROM pokemon_movimiento_forma AS mf INNER JOIN movimiento AS m ON m.id_tipo = mf.id_movimiento WHERE PokemonId = @PokemonId";
            using (IniciarConexion())
            {
                return _conexion.Query<Movimiento>(consulta, pokemon).ToList();
            }
        }


        private Pokemon GetEvolucion(Pokemon pokemonAnterior)
        {
            string consulta = "SELECT * FROM pokemon WHERE PokemonId = (SELECT pokemon_evolucionado FROM evoluciona_de WHERE pokemon_origen = @PokemonId)";
            using (IniciarConexion())
            {
                return _conexion.Query<Pokemon>(consulta, pokemonAnterior).FirstOrDefault();
            }
        }

        private Pokemon GetInvolucion(Pokemon pokemonAnterior)
        {
            string consulta = "SELECT * FROM pokemon WHERE PokemonId = (SELECT pokemon_origen FROM evoluciona_de WHERE pokemon_evolucionado = @PokemonId)";
            using (IniciarConexion())
            {
                return _conexion.Query<Pokemon>(consulta, pokemonAnterior).FirstOrDefault();
            }
        }

        #endregion

        #region Obtención de datos

        private void FillEvolucionesEInvoluciones(Pokemon pokemonSeleccionado)
        {
            pokemonSeleccionado.Evoluciones = new List<Pokemon>();
            Pokemon pokemonAnterior = pokemonSeleccionado;

            bool isMore = true;
            while (isMore)
            {
                Pokemon evolucion = GetEvolucion(pokemonAnterior);

                if (evolucion == null)
                {
                    isMore = false;
                }
                else
                {
                    pokemonSeleccionado.Evoluciones.Add(evolucion);
                    pokemonAnterior = evolucion;
                }
            }

            pokemonSeleccionado.Involuciones = new List<Pokemon>();
            pokemonAnterior = pokemonSeleccionado;

            isMore = true;
            while (isMore)
            {
                Pokemon Involucion = GetInvolucion(pokemonAnterior);

                if (Involucion == null)
                {
                    isMore = false;
                }
                else
                {
                    pokemonSeleccionado.Involuciones.Add(Involucion);
                    pokemonAnterior = Involucion;
                }
            }
        }

        private void FillMovimientos(Pokemon pokemonSeleccionado)
        {
            pokemonSeleccionado.Movimientos = new List<Movimiento>();
            pokemonSeleccionado.Movimientos = GetMovimientos(pokemonSeleccionado);
        }

        #endregion

        #region Interfaz
        private void CargarListaPokemons()
        {
            lstbxAllPokemons.Items.Clear();

            _listaPokemons = GetAllPokemon();
            foreach (Pokemon pokemon in _listaPokemons)
            {
                pokemon.tipos = new List<Tipo>();
                pokemon.tipos = GetTiposByIdPokemon(pokemon);
            }

            lstbxAllPokemons.DataSource = _listaPokemons;
            lstbxAllPokemons.DisplayMember = "nombre";
            lstbxAllPokemons.ValueMember = "PokemonId";
        }

        private void CargarComboTipos()
        {
            List<Tipo> tipos = new List<Tipo>();
            tipos.Add(new Tipo());
            tipos.AddRange(GetAllTipos());

            comboTipos.DataSource = tipos;
            comboTipos.DisplayMember = "nombre";
            comboTipos.ValueMember = "id_tipo";
        }

        private void ClearDetails()
        {
            lblPokedexValue.Text = "";
            lblNombreValue.Text = "";
            lblPesoValue.Text = "";
            lblAlturaValue.Text = "";
            lstbxMovimientosValue.DataSource = null;
            lstbxEvolucionesValue.DataSource = null;
            lstbxInvolucionesValue.DataSource = null;
        }

        #endregion

        private void lstbxAllPokemons_DoubleClick(object sender, EventArgs e)
        {
            ClearDetails();

            Pokemon pokemonSeleccionado = lstbxAllPokemons.SelectedItem as Pokemon;

            lblPokedexValue.Text = pokemonSeleccionado.PokemonId.ToString();
            lblNombreValue.Text = pokemonSeleccionado.nombre;
            lblPesoValue.Text = pokemonSeleccionado.peso.ToString();
            lblAlturaValue.Text = pokemonSeleccionado.altura.ToString();

            FillMovimientos(pokemonSeleccionado);

            if (pokemonSeleccionado.Movimientos?.Count > 0)
            {
                lstbxMovimientosValue.DataSource = pokemonSeleccionado.Movimientos;
                lstbxMovimientosValue.DisplayMember = "nombre";
                lstbxMovimientosValue.ValueMember = "id_movimiento";

                lstbxMovimientosValue.ClearSelected();
            }

            FillEvolucionesEInvoluciones(pokemonSeleccionado);

            if (pokemonSeleccionado.Evoluciones?.Count > 0)
            {
                lstbxEvolucionesValue.DataSource = pokemonSeleccionado.Evoluciones;
                lstbxEvolucionesValue.DisplayMember = "nombre";
                lstbxEvolucionesValue.ValueMember = "PokemonId";

                lstbxEvolucionesValue.ClearSelected();
                pnlEvoluciones.Visible = true;
            }
            else
            {
                pnlEvoluciones.Visible = false;

            }

            if (pokemonSeleccionado.Involuciones?.Count > 0)
            {
                lstbxInvolucionesValue.DataSource = pokemonSeleccionado.Involuciones;
                lstbxInvolucionesValue.DisplayMember = "nombre";
                lstbxInvolucionesValue.ValueMember = "PokemonId";

                lstbxInvolucionesValue.ClearSelected();
                pnlnvoluciones.Visible = true;
            }
            else
            {
                pnlnvoluciones.Visible = false;

            }

            pnlDetallePokemon.Visible = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            _listaPokemonsFiltrada = _listaPokemons.ToList();

            if (comboTipos.SelectedValue != null)
            {
                _listaPokemonsFiltrada = _listaPokemonsFiltrada.Where(x => x.tipos.Any(y => y.id_tipo == (int)comboTipos.SelectedValue)).ToList();
            }

            if (!string.IsNullOrEmpty(txtPesoDesdeFiltro.Text))
            {
                _listaPokemonsFiltrada = _listaPokemonsFiltrada.Where(x => x.peso >= int.Parse(txtPesoDesdeFiltro.Text)).ToList();

            }

            if (!string.IsNullOrEmpty(txtPesoHastaFiltro.Text))
            {
                _listaPokemonsFiltrada = _listaPokemonsFiltrada.Where(x => x.peso <= int.Parse(txtPesoHastaFiltro.Text)).ToList();

            }

            if (!string.IsNullOrEmpty(txtAlturaDesdeFiltro.Text))
            {
                _listaPokemonsFiltrada = _listaPokemonsFiltrada.Where(x => x.altura <= int.Parse(txtAlturaDesdeFiltro.Text)).ToList();
            }

            if (!string.IsNullOrEmpty(txtAlturaHastaFiltro.Text))
            {
                _listaPokemonsFiltrada = _listaPokemonsFiltrada.Where(x => x.altura <= int.Parse(txtAlturaHastaFiltro.Text)).ToList();
            }

            lstbxAllPokemons.DataSource = _listaPokemonsFiltrada;
        }

        private List<Pokemon> GenerarEquipoRandom()
        {
            List<Pokemon> equipoRandom = new List<Pokemon>();

            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                Pokemon pokemon = GetPokemonById(rnd.Next(1, 151 + 1));
                pokemon.tipos = GetTiposByIdPokemon(pokemon);
                equipoRandom.Add(pokemon);
            }

            return equipoRandom;
        }

        private void btnEquipoAleatorio_Click(object sender, EventArgs e)
        {
            List<Pokemon> equipoRandom = GenerarEquipoRandom();

            lstbxEquipoAleatorio.DataSource = equipoRandom;
            lstbxEquipoAleatorio.DisplayMember = "nombre";
            lstbxEquipoAleatorio.ValueMember = "PokemonId";
        }



        private void btnCombatir_Click(object sender, EventArgs e)
        {

            List<Pokemon> equipoPokemon1 = GenerarEquipoRandom();
            lstbxEquipo1.DataSource = equipoPokemon1;
            lstbxEquipo1.DisplayMember = "nombre";
            lstbxEquipo1.ValueMember = "PokemonId";

            List<Pokemon> equipoPokemon2 = GenerarEquipoRandom();
            lstbxEquipo2.DataSource = equipoPokemon2;
            lstbxEquipo2.DisplayMember = "nombre";
            lstbxEquipo2.ValueMember = "PokemonId";

            Combate(equipoPokemon1, equipoPokemon2);
        }

        private void Combate(List<Pokemon> equipoPokemon1, List<Pokemon> equipoPokemon2)
        {
            int pokemonDerrotadosEquipo1 = 0;
            int pokemonDerrotadosEquipo2 = 0;

            while ((pokemonDerrotadosEquipo1 < 6 && pokemonDerrotadosEquipo2 < 6))
            {
                string derrotado = string.Empty;

                derrotado = EnfrentarTipos(equipoPokemon1[pokemonDerrotadosEquipo1], equipoPokemon2[pokemonDerrotadosEquipo2]);

                if (derrotado.Contains("Empate"))
                {

                    derrotado = EntrentarPS(equipoPokemon1[pokemonDerrotadosEquipo1], equipoPokemon2[pokemonDerrotadosEquipo2]);

                    if (derrotado.Contains("Empate"))
                    {
                        derrotado = EnfrentarAltura(equipoPokemon1[pokemonDerrotadosEquipo1], equipoPokemon2[pokemonDerrotadosEquipo2]);

                        if (derrotado.Contains("Empate"))
                        {
                            derrotado = EnfrentarPeso(equipoPokemon1[pokemonDerrotadosEquipo1], equipoPokemon2[pokemonDerrotadosEquipo2]);
                        }
                    }
                }

                if (derrotado.Contains("Equipo1"))
                {
                    pokemonDerrotadosEquipo1++;
                }
                else if (derrotado.Contains("Equipo2"))
                {
                    pokemonDerrotadosEquipo2++;
                }
                else
                {
                    pokemonDerrotadosEquipo1++;
                    pokemonDerrotadosEquipo2++;
                }
            }

            if (pokemonDerrotadosEquipo1 == pokemonDerrotadosEquipo2)
            {
                lblDesenlace.Text = "Empate!";
            }
            else if (pokemonDerrotadosEquipo2 == 6)
            {
                lblDesenlace.Text = "GANA EL EQUIPO 1!";
            }
            else if (pokemonDerrotadosEquipo1 == 6)
            {
                lblDesenlace.Text = "GANA EL EQUIPO 2!";
            }
        }

        private string EnfrentarTipos(Pokemon pokemonEquipo1, Pokemon pokemonEquipo2)
        {
            string derrotado = string.Empty;
            bool isDerrotado = false;

            isDerrotado = BuscarDebilidad(pokemonEquipo1, pokemonEquipo2);
            if (isDerrotado)
                return "Equipo1 derrotado";

            isDerrotado = BuscarDebilidad(pokemonEquipo2, pokemonEquipo1);
            if (isDerrotado)
                return "Equipo2 derrotado";

            return "Empate";
        }

        private bool BuscarDebilidad(Pokemon pokemon1, Pokemon pokemon2)
        {
            bool derrotado = false;


            switch (pokemon1.tipos[0].nombre)
            {
                case "Acero":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Lucha":
                            derrotado = true;
                            break;
                        case "Fuego":
                            derrotado = true;
                            break;
                        case "Tierra":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;

                case "Agua":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Planta":
                            derrotado = true;
                            break;
                        case "Eléctrico":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;

                case "Bicho":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Volador":
                            derrotado = true;
                            break;
                        case "Fuego":
                            derrotado = true;
                            break;
                        case "Roca":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Dragón":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Hada":
                            derrotado = true;
                            break;
                        case "Hielo":
                            derrotado = true;
                            break;
                        case "Dragón":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Eléctrico":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Tierra":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Fantasma":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Fantasma":
                            derrotado = true;
                            break;
                        case "Siniestro":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Fuego":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Tierra":
                            derrotado = true;
                            break;
                        case "Agua":
                            derrotado = true;
                            break;
                        case "Roca":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Hada":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Acero":
                            derrotado = true;
                            break;
                        case "Veneno":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Hielo":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Lucha":
                            derrotado = true;
                            break;
                        case "Acero":
                            derrotado = true;
                            break;
                        case "Roca":
                            derrotado = true;
                            break;
                        case "Fuego":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Lucha":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Psíquico":
                            derrotado = true;
                            break;
                        case "Volador":
                            derrotado = true;
                            break;
                        case "Hielo":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Normal":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Lucha":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Planta":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Volador":
                            derrotado = true;
                            break;
                        case "Bicho":
                            derrotado = true;
                            break;
                        case "Veneno":
                            derrotado = true;
                            break;
                        case "Hielo":
                            derrotado = true;
                            break;
                        case "Fuego":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Psíquico":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Bicho":
                            derrotado = true;
                            break;
                        case "Fantasma":
                            derrotado = true;
                            break;
                        case "Siniestro":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Roca":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Lucha":
                            derrotado = true;
                            break;
                        case "Tierra":
                            derrotado = true;
                            break;
                        case "Acero":
                            derrotado = true;
                            break;
                        case "Agua":
                            derrotado = true;
                            break;
                        case "Planta":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Siniestro":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Lucha":
                            derrotado = true;
                            break;
                        case "Hada":
                            derrotado = true;
                            break;
                        case "Bicho":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Tierra":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Agua":
                            derrotado = true;
                            break;
                        case "Planta":
                            derrotado = true;
                            break;
                        case "Hielo":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Veneno":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Tierra":
                            derrotado = true;
                            break;
                        case "Psíquico":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;


                case "Volador":
                    switch (pokemon2.tipos[0].nombre)
                    {
                        case "Roca":
                            derrotado = true;
                            break;
                        case "Hielo":
                            derrotado = true;
                            break;
                        case "Eléctrico":
                            derrotado = true;
                            break;
                        default:
                            break;
                    }
                    break;
            }

            return derrotado;
        }

        private string EntrentarPS(Pokemon pokemonEquipo1, Pokemon pokemonEquipo2)
        {
            string derrotado = string.Empty;
            bool isDerrotado = false;

            isDerrotado = pokemonEquipo1.ps < pokemonEquipo2.ps;
            if (isDerrotado)
                return "Equipo1 derrotado";

            isDerrotado = pokemonEquipo2.ps < pokemonEquipo1.ps;

            if (isDerrotado)
                return "Equipo2 derrotado";

            return "Empate";
        }

        private string EnfrentarAltura(Pokemon pokemonEquipo1, Pokemon pokemonEquipo2)
        {
            string derrotado = string.Empty;
            bool isDerrotado = false;

            isDerrotado = pokemonEquipo1.altura < pokemonEquipo2.altura;
            if (isDerrotado)
                return "Equipo1 derrotado";

            isDerrotado = pokemonEquipo2.altura < pokemonEquipo1.altura;

            if (isDerrotado)
                return "Equipo2 derrotado";

            return "Empate";
        }

        private string EnfrentarPeso(Pokemon pokemonEquipo1, Pokemon pokemonEquipo2)
        {
            string derrotado = string.Empty;
            bool isDerrotado = false;

            isDerrotado = pokemonEquipo1.peso < pokemonEquipo2.peso;
            if (isDerrotado)
                return "Equipo1 derrotado";

            isDerrotado = pokemonEquipo2.peso < pokemonEquipo1.peso;

            if (isDerrotado)
                return "Equipo2 derrotado";

            return "Empate";
        }

    }
}
