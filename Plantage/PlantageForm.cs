using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plantage
{
  public partial class PlantageForm : Form
  {
    Graphics graphics;
    Pen pen = new Pen(Color.Black, 1);
    SolidBrush brush = new SolidBrush(Color.Red);

    int lengthF;          // Schrittlänge
    double direction;         // Richtung in Grad
    double rotation = 30;   // Drehung in Grad 

    Point a, b;
    


    public PlantageForm()
    {
      InitializeComponent();
    }

    private void PlantageForm_Load(object sender, EventArgs e)
    {
      graphics = CreateGraphics();
    }

    private void btnInsertRuleUpperF_Click(object sender, EventArgs e)
    {
      tbRuleset.AppendText("F");
    }

    private void btnInsertRuleLowerF_Click(object sender, EventArgs e)
    {
      tbRuleset.AppendText("f");
    }

    private void btnInsertRulePlus_Click(object sender, EventArgs e)
    {
      tbRuleset.AppendText("+");
    }

    private void btnInsertRuleMinus_Click(object sender, EventArgs e)
    {
      tbRuleset.AppendText("-");
    }

    private void btnInsertRuleBracketOpen_Click(object sender, EventArgs e)
    {
      tbRuleset.AppendText("[");
    }

    private void btnInsertRuleBracketClose_Click(object sender, EventArgs e)
    {
      tbRuleset.AppendText("]");
    }

    private void btnGenerateRandomizedRuleset_Click(object sender, EventArgs e)
    {

    }

    private void btnGeneratePlant_Click(object sender, EventArgs e)
    {

      a = new Point(600, 600); // Start-Punkt
      direction = -85;        // Start-Richtung in Grad 
      lengthF = (int)numStep.Value;
      rotation = (float)numDegree.Value;

      turtleGraphic("F", 6);  // Axiom und Iterationstiefe 
    }

    private void turtleGraphic(string instruction, int depth)
    {
      if (depth == 0) return;
      depth -= 1;

      Point aMark = new Point(0, 0);
      double directionMark = 0;
      // Dummy-Werte

      int i;
      char c;
      for (i = 0; i < instruction.Length; i++)
      {
        c = instruction[i];
        // Schritt Vorwärts
        if (c == 'F')
        {

          // Produktionsregel iterieren, solange Tiefe nicht erreicht ist
          turtleGraphic(tbRuleset.ToString(), depth);

          // Zeichnen: Ab 'a' in Richtung 'direction' einen Schritt der Länge 'lengthF'
          if (depth == 0)
          {
            double rad = 2 * Math.PI / 360 * direction; // Grad -> Radiant

            int p = (int)(lengthF * Math.Cos(rad));
            int q = (int)(lengthF * Math.Sin(rad));

            b = new Point(a.X + p, a.Y + q);

            graphics.DrawLine(pen, a, b);

            a = b; // Neuer Startpunkt
          }
        }

        // Drehung links herum
        else if (c == '+') direction += rotation;

        // Drehung rechts herum
        else if (c == '-') direction -= rotation;

        // Position und Richtung speichern
        else if (c == '[')
        {
          aMark = a;
          directionMark = direction;
        }

        // Zurück zu gespeicherter Position und Richtung
        else if (c == ']')
        {
          a = aMark;
          direction = directionMark;
        } 
      }
    } 

    private void btnOpenRuleset_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "Ruleset (*.prs)|*.prs| Textdateien (*.txt)|*.txt| Alle Dateien (*.*)|*.*";
      ofd.Title = "Datei zum Öffnen auswählen";
      if (ofd.ShowDialog() == DialogResult.OK)
      {
      }
    }

    private void btnSaveRuleset_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfd = new SaveFileDialog();
      sfd.Filter = "Ruleset (*.prs)|*.prs| Textdateien (*.txt)|*.txt| Alle Dateien (*.*)|*.*";
      sfd.Title = "Datei zum Speichern auswählen";
      if (sfd.ShowDialog() == DialogResult.OK)
      {
      }
    }

    private void btnEraseRuleset_Click(object sender, EventArgs e)
    {
      tbRuleset.Clear();
    }

  }
}
