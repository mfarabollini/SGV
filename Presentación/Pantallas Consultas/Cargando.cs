﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Presentación.Pantallas_Consultas
{
    public partial class Cargando : Form
    {
// Declaraciones globales
        #region Declaraciones
        // Tiempo de espera por defecto
        const int DEFAULT_TIME = 1000;
        // Hilo
        Thread t;
        #endregion

        public Cargando()
        {
            InitializeComponent();
            // Adhiere dos nuevos eventos
            this.Shown += new EventHandler(fSplashScreen_Shown);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        // Crea el Hilo para mostrar el Loading
        void fSplashScreen_Shown(object sender, EventArgs e)
        {
            initvalues();
            t = new System.Threading.Thread(initApplication);
            t.Start();
        }

        //Aborta el hilo creado
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null && t.IsAlive)
            {
                t.Abort();
                t = null;
            }
        }

        // Inicialización del Loading
        private void initvalues()
        {
        }

        // Textos mostrados en la carga
        public void initApplication()
        {
            Thread.Sleep(DEFAULT_TIME);
            if (this.InvokeRequired) this.Invoke(new Action(finishProcess));
        }

        // Setea Mensaje
        public void setMessage(string msg)
        {
        }

        // Finaliza el forms
        private void finishProcess()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

    }
}
