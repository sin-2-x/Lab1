﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1 {
  public partial class Form2 : Form {
    public Form2() {
      InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e) {
      
    }




    string RandomTextBoxLastCorrect = "";
    private void textAddNumber_TextChanged(object sender, EventArgs e) {
      string sequenceTextNewValue = textAddNumber.Text;
      for (int i = 0; i < sequenceTextNewValue.Length; i++) {
        if ((sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9'|| (sequenceTextNewValue.Length>1 && sequenceTextNewValue.ElementAt(0) == '0' && sequenceTextNewValue.ElementAt(1) == '0'))) {//набор алфавита
          textAddNumber.Text = RandomTextBoxLastCorrect;
          return;
        }
      }
      textAddNumber.Text = sequenceTextNewValue;
      RandomTextBoxLastCorrect = sequenceTextNewValue;
      return;
    }

    private void label1_Click(object sender, EventArgs e) {

    }
  }
}