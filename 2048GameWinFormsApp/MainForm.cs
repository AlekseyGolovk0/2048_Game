using Microsoft.VisualBasic.ApplicationServices;

namespace _2048GameWinFormsApp
{
    public partial class MainForm : Form
    {
        private bool _gameEnded = false;
        public User user;
        private int mapSize = 4;
        private Label[,] _labelsMap;
        private static Random random = new Random();
        private static int score;
        private static int bestScore;
        private int sizeLabel = 70;
        private int distanceBetweenLabels = 6;
        private int indentLabel = 60;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            var userNameForm = new UserNameForm();
            userNameForm.ShowDialog();
            user = new User { Name = userNameForm.UserName, Score = 0 };
            score = 0;

            var sizeForm = new SizeForm();
            sizeForm.ShowDialog();

            CalculateMapSize(sizeForm.radioButtons);

            InitMap();
            GenerateNumber();
            SetLabelsColor();
            ShowBeastScore();
            ShowScore();
        }

        private void CalculateMapSize(List<RadioButton> radioButtons)
        {
            foreach (var item in radioButtons)
            {
                if (item.Checked)
                {
                    mapSize = Convert.ToInt32(item.Text[0].ToString());
                    break;
                }
            }
        }

        private void InitMap()
        {
            this.ClientSize = new Size(mapSize*(sizeLabel+ distanceBetweenLabels),
                mapSize * (sizeLabel + distanceBetweenLabels)+ indentLabel);

            _labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    _labelsMap[i, j] = newLabel;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();

            label.BackColor = Color.WhiteSmoke;
            label.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(sizeLabel, sizeLabel);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = indexColumn * (sizeLabel + distanceBetweenLabels);
            int y = indentLabel + indexRow * (sizeLabel + distanceBetweenLabels);
            label.Location = new Point(x, y);

            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && 
                e.KeyCode != Keys.Up && e.KeyCode != Keys.Down ||  _gameEnded)
            {
                return;
            }
            if (e.KeyCode == Keys.Right)
                MoveRight();

            if (e.KeyCode == Keys.Left)
                MoveLeft();

            if (e.KeyCode == Keys.Up)
                MoveUp();

            if (e.KeyCode == Keys.Down)
                MoveDown();

            GenerateNumber();
            SetLabelsColor();
            ShowScore();

            if (WinGame())
            {
                MessageBox.Show("Вы выйграли!");
            }
            if (EndGame())
            {
                MessageBox.Show("Игра закончена!");
            }
        }

        private void GenerateNumber()
        {
            while (HasLabelsEmpty())
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;
                if (_labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    _labelsMap[indexRow, indexColumn].Text = random.Next(0, 100) < 75 ? "2" : "4";
                    break;
                }
            }
        }

        private bool HasLabelsEmpty()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (_labelsMap[i, j].Text == string.Empty)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void SetLabelsColor()
        {
            for (int i = mapSize - 1; i >= 0; i--)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (_labelsMap[j, i].Text != string.Empty)
                    {
                        SelectColor(j, i);
                    }
                    else
                    {
                        _labelsMap[j, i].BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void ShowScore()
        {
            score = 0;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (_labelsMap[i, j].Text != string.Empty)
                    {
                        score += int.Parse(_labelsMap[i, j].Text);
                    }
                }
            }
            scoreLabel.Text = score.ToString();
        }

        private void ShowBeastScore()
        {
            SetBestScore();
            if (score > bestScore)
            {
                bestScore = score;
                var newBestUser = new User
                {
                    Name = user.Name,
                    Score = bestScore
                };
                UserManager.Add(newBestUser);
            }
            bestScoreLabel.Text = bestScore.ToString();

        }

        private void SetBestScore()
        {
            var users = UserManager.GetAll();
            if (users.Count == 0)
            {
                return;
            }
            bestScore = users[0].Score;
            foreach (var user in users)
            {
                if (user.Score > bestScore)
                {
                    bestScore = user.Score;
                }
            }
        }

        private void MoveDown()
        {
            for (int i = mapSize - 1; i >= 0; i--)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (_labelsMap[j, i].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (_labelsMap[k, i].Text != string.Empty)
                            {
                                if (_labelsMap[k, i].Text == _labelsMap[j, i].Text)
                                {
                                    var number = int.Parse(_labelsMap[j, i].Text);
                                    _labelsMap[j, i].Text = (number * 2).ToString();
                                    _labelsMap[k, i].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = mapSize - 1; i >= 0; i--)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (_labelsMap[j, i].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (_labelsMap[k, i].Text != string.Empty)
                            {
                                _labelsMap[j, i].Text = _labelsMap[k, i].Text;
                                _labelsMap[k, i].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveUp()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (_labelsMap[j, i].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (_labelsMap[k, i].Text != string.Empty)
                            {
                                if (_labelsMap[k, i].Text == _labelsMap[j, i].Text)
                                {
                                    var number = int.Parse(_labelsMap[j, i].Text);
                                    _labelsMap[j, i].Text = (number * 2).ToString();
                                    _labelsMap[k, i].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (_labelsMap[j, i].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (_labelsMap[k, i].Text != string.Empty)
                            {
                                _labelsMap[j, i].Text = _labelsMap[k, i].Text;
                                _labelsMap[k, i].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (_labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (_labelsMap[i, k].Text != string.Empty)
                            {
                                if (_labelsMap[i, k].Text == _labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(_labelsMap[i, j].Text);
                                    _labelsMap[i, j].Text = (number * 2).ToString();
                                    _labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (_labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (_labelsMap[i, k].Text != string.Empty)
                            {
                                _labelsMap[i, j].Text = _labelsMap[i, k].Text;
                                _labelsMap[i, k].Text = string.Empty;
                                break;
                            }

                        }
                    }
                }
            }
        }

        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (_labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (_labelsMap[i, k].Text != string.Empty)
                            {
                                if (_labelsMap[i, k].Text == _labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(_labelsMap[i, j].Text);
                                    _labelsMap[i, j].Text = (number * 2).ToString();
                                    _labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (_labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (_labelsMap[i, k].Text != string.Empty)
                            {
                                _labelsMap[i, j].Text = _labelsMap[i, k].Text;
                                _labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }


    

        private void SelectColor(int indexRow, int indexColumn)
        {
            {
                switch (int.Parse(_labelsMap[indexRow, indexColumn].Text))
                {
                    case < 4: _labelsMap[indexRow, indexColumn].BackColor = Color.Gainsboro; break;
                    case < 8: _labelsMap[indexRow, indexColumn].BackColor = Color.LightGray; break;
                    case < 16: _labelsMap[indexRow, indexColumn].BackColor = Color.Silver; break;
                    case < 32: _labelsMap[indexRow, indexColumn].BackColor = Color.DarkGray; break;
                    case < 64: _labelsMap[indexRow, indexColumn].BackColor = Color.Gray; break;
                    case < 128: _labelsMap[indexRow, indexColumn].BackColor = Color.DimGray; break;
                    case >= 256: _labelsMap[indexRow, indexColumn].BackColor = Color.Black; break;
                }

            }
        }


        private bool EndGame()
        {
            if (_gameEnded)
            {
                return true;
            }

            var isGameEnd = !HasLabelsEmpty();

            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (_labelsMap[i, j].Text == _labelsMap[i + 1, j].Text || 
                        _labelsMap[i, j].Text == _labelsMap[i, j + 1].Text)
                    {
                        isGameEnd = false;
                    }
                }
            }

            if (isGameEnd && !_gameEnded)
            {
                _gameEnded = true;
                user.Score = score;
                UserManager.Add(user);
                ShowBeastScore();
            }

            return isGameEnd;
        }

        private bool WinGame()
        {
            var isGameWin = false;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (_labelsMap[i, j].Text == "2048")
                    {
                        isGameWin = true;
                    }
                }
            }
            return isGameWin;
        }

        private void RrestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score = 0;
            Application.Restart();
        }

        private void RulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила игры:\r\n\r\nПоле — квадрат 4×4 клетки, в начале игры на поле появляются дв" +
                           "е плитки с числами 2 или 4. \r\nПередвижение плиток — с помощью стрелок на клавиатуре (или " +
                           "свайпов на мобильном устройстве) плитки можно перемещать вверх, вниз, влево или вправо. \r\nОб" +
                           "ъединение плиток — если при перемещении две плитки с одинаковыми числами сталкиваются, они объедин" +
                           "яются в одну плитку с числом, равным сумме этих двух чисел.  \r\nПоявление новых плиток — после кажд" +
                           "ого перемещения на пустой клетке поля появляется новая плитка с числом 2 или 4. \r\nКонец игры — игр" +
                           "а заканчивается, когда на поле не осталось свободных клеток и нет возможных ходов для объединения плиток.");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gameEnded=false;
            var resultForm = new ResultForm();
            resultForm.ShowDialog();
        }
    }
}
