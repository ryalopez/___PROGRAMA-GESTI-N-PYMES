﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó mediante una herramienta.
//     Los cambios del archivo se perderán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CentroTrabajo
{
	public virtual int idCentro
	{
		get;
		private set;
	}

	public virtual int idEmpresa
	{
		get;
		set;
	}

	public virtual IEnumerable<Empleado> Empleado
	{
		get;
		set;
	}

}

