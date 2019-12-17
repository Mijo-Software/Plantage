using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plantage
{
  public partial class PlantageForm : Form
  {
    private Graphics graphics;
    private readonly Pen pen = new Pen(color: Color.Black, width: 1);
    private readonly SolidBrush brush = new SolidBrush(color: Color.Red);
    private int lengthF;          // Schrittlänge
    private double direction;         // Richtung in Grad
    private double rotation = 30;   // Drehung in Grad 

    private Point a, b;

    public PlantageForm() => InitializeComponent();

    private void PlantageForm_Load(object sender, EventArgs e)
    {
      graphics = CreateGraphics();
    }

    private void ButtonInsertRuleUpperF_Click(object sender, EventArgs e)
    {
      textboxRuleset.AppendText(text: "F");
    }

    private void ButtonInsertRuleLowerF_Click(object sender, EventArgs e)
    {
      textboxRuleset.AppendText(text: "f");
    }

    private void ButtonInsertRulePlus_Click(object sender, EventArgs e)
    {
      textboxRuleset.AppendText(text: "+");
    }

    private void ButtonInsertRuleMinus_Click(object sender, EventArgs e)
    {
      textboxRuleset.AppendText(text: "-");
    }

    private void ButtonInsertRuleBracketOpen_Click(object sender, EventArgs e)
    {
      textboxRuleset.AppendText(text: "[");
    }

    private void ButtonInsertRuleBracketClose_Click(object sender, EventArgs e)
    {
      textboxRuleset.AppendText(text: "]");
    }

    private void ButtonGenerateRandomizedRuleset_Click(object sender, EventArgs e)
    {
    }

    private void ButtonGeneratePlant_Click(object sender, EventArgs e)
    {
      a = new Point(600, 600); // Start-Punkt
      direction = -85;        // Start-Richtung in Grad 
      lengthF = (int)numStep.Value;
      rotation = (float)numAngle.Value;
      TurtleGraphic(instruction: "F", depth: 6);  // Axiom und Iterationstiefe 
    }

    private void TurtleGraphic(string instruction, int depth)
    {
      if (depth == 0)
      {
        return;
      }
      depth--;
      Point aMark = new Point(x: 0, y: 0);
      double directionMark = 0;
      // Dummy-Werte
      int i;
      char c;
      for (i = 0; i < instruction.Length; i++)
      {
        c = instruction[index: i];
        // Schritt Vorwärts
        if (c == 'F')
        {
          // Produktionsregel iterieren, solange Tiefe nicht erreicht ist
          TurtleGraphic(instruction: textboxRuleset.ToString(), depth: depth);
          // Zeichnen: Ab 'a' in Richtung 'direction' einen Schritt der Länge 'lengthF'
          if (depth == 0)
          {
            double rad = 2 * Math.PI / 360 * direction; // Grad -> Radiant
            int p = (int)(lengthF * Math.Cos(d: rad));
            int q = (int)(lengthF * Math.Sin(a: rad));
            b = new Point(x: a.X + p, y: a.Y + q);
            graphics.DrawLine(pen: pen, pt1: a, pt2: b);
            a = b; // Neuer Startpunkt
          }
        }
        // Drehung links herum
        else if (c == '+')
        {
          direction += rotation;
        }
        // Drehung rechts herum
        else if (c == '-')
        {
          direction -= rotation;
        }
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

    private void ButtonOpenRuleset_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog
      {
        Filter = "Ruleset (*.prs)|*.prs| Textdateien (*.txt)|*.txt| Alle Dateien (*.*)|*.*",
        Title = "Datei zum Öffnen auswählen"
      };
      if (ofd.ShowDialog() == DialogResult.OK)
      {
      }
    }

    private void ButtonSaveRuleset_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfd = new SaveFileDialog
      {
        Filter = "Ruleset (*.prs)|*.prs| Textdateien (*.txt)|*.txt| Alle Dateien (*.*)|*.*",
        Title = "Datei zum Speichern auswählen"
      };
      if (sfd.ShowDialog() == DialogResult.OK)
      {
      }
    }

    private void ButtonEraseRuleset_Click(object sender, EventArgs e)
    {
      textboxRuleset.Clear();
    }
  }
}
