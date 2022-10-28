namespace Hourly
{
    public partial class frm_home : Form
    {
        private static ListBox.ObjectCollection? list_items;
        private static ListBox.ObjectCollection? list_calc;

        public frm_home()
        {
            InitializeComponent();
            list_items = ltx_result.Items;
            list_calc = ltx_calc.Items;

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            list_items.Clear();

            list_items.Add("============================================");
            list_items.Add($"Início do expediente: {dtp_entrada.Text}");
            list_items.Add($"Carga horária: {dtp_carga_horaria.Text}");
            list_items.Add($"Duração do almoço: {dtp_almoco.Text}");
            list_items.Add("============================================");

            retornaTotal(dtp_entrada.Text, dtp_almoco.Text, dtp_carga_horaria.Text);
        }

        private void retornaTotal(string inicio, string almoco, string cargaHoraria)
        {

            DateTime hr_inicio = DateTime.Parse(inicio);
            DateTime hr_almoco = DateTime.Parse(almoco);
            DateTime hr_ch = DateTime.Parse(cargaHoraria);

            // ==================================
            // inicio + carga_horaria + almoco
            // ==================================
            DateTime resultado = hr_inicio.Add(hr_ch.TimeOfDay).Add(hr_almoco.TimeOfDay);


            list_items.Add($"Você precisar bater o ponto às: {resultado.TimeOfDay}");
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            calculaDiferenca(dtp_inicio.Text, dtp_fim.Text);
        }

        private void calculaDiferenca(string inicio, string fim)
        {
            DateTime hr_inicio = DateTime.Parse(inicio);
            DateTime hr_fim = DateTime.Parse(fim);

            DateTime resultado = hr_fim.Subtract(hr_inicio.TimeOfDay);
            list_calc.Add($"Diferença é de: {resultado.TimeOfDay}");

        }
    }
}