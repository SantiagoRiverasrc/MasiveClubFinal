﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Request.Producto
{
    public class UpdateProductoRequest
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public string Img { get; set; }
        public string Audio { get; set; }
    }
}