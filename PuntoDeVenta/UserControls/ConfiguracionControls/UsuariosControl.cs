using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;

namespace PuntoDeVenta.UserControls.ConfiguracionControls
{
    public partial class UsuariosControl : UserControl
    {
        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IUsuarioService _usuarioService;
        private readonly IPerfilService _perfilService;

        private List<UsuarioResponse> _usuarios = new List<UsuarioResponse>();
        private List<PerfilResponse> _perfiles = new List<PerfilResponse>();

        public UsuarioResponse selectedUsuario;

        public UsuariosControl()
        {
            _usuarioService = new UsuarioService(_context);
            _perfilService = new PerfilService(_context);
            InitializeComponent();
        }

        public async Task GetAllUsuarios()
        {
            try
            {
                var response = await _usuarioService.GetAll(null);

                if (response != null && response.success)
                {
                    _usuarios = response.response!;
                    SetearUsuarios(_usuarios);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task GetAllPerfiles()
        {
            try
            {
                var response = await _perfilService.GetAll(null);

                if (response != null && response.success)
                {
                    _perfiles = response.response!;
                    SetearPerfiles(_perfiles);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetearPerfiles(List<PerfilResponse> perfilesResponse)
        {
            comboPerfil.DisplayMember = "Descripcion";
            comboPerfil.ValueMember = "Id";
            comboPerfil.DataSource = perfilesResponse;
        }

        public void SetearUsuarios(List<UsuarioResponse> usuarios)
        {
            if (usuarios != null && usuarios.Any())
            {
                var listaUsuarios = usuarios.Select(x => new
                {
                    x.Id,
                    Usuario = x.User,
                    x.Nombre,
                    x.Apellido,
                    x.Email,
                    x.FechaCreacion,
                    Perfil = x.Perfil.Descripcion,
                    x.Habilitado
                })!.ToList();

                dvUsuarios.DataSource = null;
                dvUsuarios.DataSource = listaUsuarios;
                dvUsuarios.Refresh();
                dvUsuarios.Invalidate();

                dvUsuarios.Visible = true;
                labelSinResultados.Visible = false;
            }
            else
            {
                dvUsuarios.Visible = false;
                labelSinResultados.Visible = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _ = GuardarUsuario();
            _ = GetAllUsuarios();
        }

        public async Task GuardarUsuario()
        {
            try
            {
                if (txtNombre.Text == "" || txtUsuario.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre, usuario y contraseña válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ResponseModel<UsuarioResponse> response = new ResponseModel<UsuarioResponse>();

                    UsuarioRequest usuarioRequest = new UsuarioRequest()
                    {
                        Id = 0,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Email = txtEmail.Text,
                        User = txtUsuario.Text,
                        Password = txtPassword.Text,
                        IdPerfil = Convert.ToInt32(comboPerfil.SelectedValue),
                        Telefono = "",
                        Habilitado = checkHabilitado.Checked
                    };

                    if (selectedUsuario != null && selectedUsuario.Id > 0)
                    {
                        usuarioRequest!.Id = selectedUsuario.Id;
                        usuarioRequest.FechaCreacion = selectedUsuario.FechaCreacion;
                        response = await _usuarioService.Update(usuarioRequest);
                    }
                    else
                    {
                        usuarioRequest.FechaCreacion = DateTime.Now;
                        response = await _usuarioService.Insert(usuarioRequest);
                        _usuarios.Add(response.response!);
                    }

                    if (response != null && response.success)
                    {
                        SetearUsuarios(_usuarios);
                        SetUsuario(null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SetUsuario(UsuarioResponse usuario)
        {
            selectedUsuario = usuario;            
            txtNombre.Text = usuario != null ? usuario.Nombre : "";
            txtApellido.Text = usuario != null ? usuario.Apellido : "";
            txtUsuario.Text = usuario != null ? usuario.User : "";
            txtPassword.Text = usuario != null ? usuario.Password : "";
            txtEmail.Text = usuario != null ? usuario.Email : "";
            comboPerfil.SelectedValue = usuario != null && usuario.IdPerfil > 0 ? usuario!.IdPerfil : _perfiles.FirstOrDefault()!.Id;
            checkHabilitado.Checked = usuario != null ? usuario.Habilitado : true;
            labelTitle.Text = usuario != null ? "MODIFICAR USUARIO" : "NUEVO USUARIO";
        }

        private void dvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetUsuario(_usuarios.Where(u => u.Id.ToString() == dvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString()!).FirstOrDefault());
        }

    }
}
