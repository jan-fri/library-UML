﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Materiał biblioteczny
{
	public virtual int ISBN
	{
		get;
		set;
	}

	public virtual string Tytuł
	{
		get;
		set;
	}

	public virtual date Data_wydania
	{
		get;
		set;
	}

	public virtual string Język
	{
		get;
		set;
	}

	public virtual string Gatunek
	{
		get;
		set;
	}

	public virtual string Miejsce
	{
		get;
		set;
	}

	public virtual readonly int Kod_egzemplarza
	{
		get;
		set;
	}

	public virtual string Opis
	{
		get;
		set;
	}

	public virtual void Zapisanie_do_katalogu()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Usuwanie_z_katalogu()
	{
		throw new System.NotImplementedException();
	}

}

