﻿using Inventario_residencias.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_residencias.Interfaces
{
    public interface IUsuarioRepositorio
    {
        List<Usuario> obtenerUsuarios(string nombre, int limite, int offset);

        byte[] ImageToByteArray(Image image);

        string hashPassword(string password);

        bool verifyPassword(string passwordBd, string passwordLg);

        bool agregarUsuario(Usuario usuario);

        bool modificarUsuario(Usuario usuario);

        bool eliminarUsuario(int usuarioId);


    }
}