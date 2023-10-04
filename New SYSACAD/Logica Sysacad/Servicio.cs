﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public class Servicio
    {
        private string nombre;
        private decimal precioTotal;
        private decimal precioCuota;
        private byte cuotasImpagas;
        private byte cuotasAbonadas;
        private byte cuotasTotales;

        public Servicio(string nombre, decimal precioTotal, byte cuotasTotales)
        {
            this.nombre = nombre;
            this.precioTotal = precioTotal;
            this.cuotasTotales = cuotasTotales;
            precioCuota = precioTotal / cuotasTotales;
            cuotasImpagas = cuotasTotales;
        }


        public string Nombre
        {
            get { return nombre; }
        }

        public decimal PrecioTotal
        {
            get { return precioTotal; }
        }

        public decimal PrecioCuota
        {
            get { return precioCuota; }
        }

        public byte CuotasImpagas
        {
            get { return cuotasImpagas; }
        }

        public byte CuotasAbonadas
        {
            get { return cuotasAbonadas; }
        }

        public byte CuotasTotales
        {
            get { return cuotasTotales; }
        }



        public void ActualizarCuotas(byte cuotasPagadas)
        {
            cuotasAbonadas += cuotasPagadas;
            cuotasImpagas -= cuotasPagadas;
        }

        public bool VerificarEsServicioImpago()
        {
            if (cuotasImpagas > 0 && cuotasAbonadas < cuotasTotales)
            {
                return true;
            }
            return false; //  ya estaban completas, no va a pagar de nuevo!
        }

        public decimal CalcularMontoAPagar(byte cuotasPagadas)
        {
            return precioCuota * cuotasPagadas;
        }


    }
}