using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Инициализация компонентов, которые нельзя добавить через дизайнер
            this.openFileDialog = new OpenFileDialog { Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*" };

            // Настройка DataGridView
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns.Add("NumberColumn", "Номер лексемы");
            dataGridView.Columns.Add("ExpressionColumn", "Выражение");
            dataGridView.Columns.Add("FormColumn", "Описание");

            // Подписка на события
            chooseFileButton.Click += ChooseFileButton_Click;
            analyzeButton.Click += AnalyzeButton_Click;
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox.Text))
            {
                MessageBox.Show("Введите текст или выберите файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Token> tokens = Tokenize(richTextBox.Text);
            dataGridView.Rows.Clear();

            for (int i = 0; i < tokens.Count; i++)
            {
                dataGridView.Rows.Add((i + 1).ToString(), tokens[i].Value, tokens[i].Description);
            }
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathLabel.Text = openFileDialog.FileName;
                try
                {
                    richTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<Token> Tokenize(string input)
        {
            List<Token> tokens = new List<Token>();

            string pattern = @"(if|then|else|:=|;|[a-zA-Z_][a-zA-Z0-9_]*|""[^""]*""|\d+|<|>|=)";
            foreach (Match match in Regex.Matches(input, pattern))
            {
                tokens.Add(new Token(match.Value));
            }

            return tokens;
        }
    }

    public class Token
    {
        public string Type { get; }
        public string Value { get; }
        public string Description { get; }

        public Token(string value)
        {
            Value = value;

            if (IsKeyword(value))
            {
                Type = "KEYWORD";
                Description = GetTokenDescription(value);
            }
            else if (Regex.IsMatch(value, @"^\d+$"))
            {
                Type = "NUMBER";
                Description = "Число";
            }
            else if (Regex.IsMatch(value, @"^[a-zA-Z_][a-zA-Z0-9_]*$"))
            {
                Type = "IDENTIFIER";
                Description = "Идентификатор";
            }
            else if (Regex.IsMatch(value, "^\".*\"$"))
            {
                Type = "STRING";
                Description = "Строковая константа";
            }
            else
            {
                Type = "SYMBOL";
                Description = GetTokenDescription(value);
            }
        }

        private bool IsKeyword(string token)
        {
            string[] keywords = { "if", "then", "else" };
            return Array.Exists(keywords, k => k.Equals(token, StringComparison.OrdinalIgnoreCase));
        }

        private string GetTokenDescription(string token) => token switch
        {
            "if" => "Условный оператор",
            "then" => "Тогда",
            "else" => "Иначе",
            ":=" => "Присваивание",
            ";" => "Точка с запятой",
            "<" => "Меньше",
            ">" => "Больше",
            "=" => "Равно",
            _ => "Неизвестный символ"
        };
    }
}