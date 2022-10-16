using System.Windows.Forms;

static class Validaciones
{
    public static void ValidarTextBoxNoVacio(ErrorProvider errorProvider, TextBox textBox, string mensaje)
    {
        if (textBox.TextLength == 0)
        {
            errorProvider.SetError(textBox, mensaje);
        }
        else
        {
            errorProvider.SetError(textBox, "");
        }
    }

    public static void SoloNumero(KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
    }

    public static void SoloLetra(KeyPressEventArgs e)
    {
        if (char.IsDigit(e.KeyChar)) e.Handled = true;
    }

    public static void SoloNumeroDecimal(TextBox textBox, KeyPressEventArgs e)
    {
        if (((e.KeyChar < 48 || e.KeyChar > 57) && !char.IsControl(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46))
        {
            e.Handled = true;
            return;
        }

        if (e.KeyChar == 46)
        {
            if (textBox.Text.IndexOf(e.KeyChar) != -1)
                e.Handled = true;
        }
    }
}