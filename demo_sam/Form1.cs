using Microsoft.EntityFrameworkCore;


namespace demo_sam
{
    public partial class DemoEx : Form
    {
        public DemoEx()
        {
            InitializeComponent();

            using (var db = new Context())
            {
                db.Database.EnsureCreated(); // создает БД и таблицы, если их нет
            }
            RefreshTeachers();
        }

        public void RefreshTeachers()
        {
            using (var db = new Context())
            {
                // Заранее загружаем нужные данные
                var teachers = db.Teachers.Include(t => t.TeacherType).Include(p => p.TeachersCources).ToList();
                var teachertypes = db.TeacherTypes.ToList();

                // Обновляем DataGridView1
                dataGridView1.Rows.Clear();
                foreach (var row in teachers)
                {
                    dataGridView1.Rows.Add(row.Name, row.Phone, row.TeacherType.Name);
                }

                // Обновляем DataGridView2
                dataGridView2.Rows.Clear();
                foreach (var row in teachertypes)
                {
                    dataGridView2.Rows.Add(row.Name);
                }

                // Обновляем comboBox1
                comboBox1.DataSource = null; // сбрасываем источник данных
                comboBox1.DataSource = teachers;
                comboBox1.DisplayMember = "Name";     // что отображать
                comboBox1.ValueMember = "Id";         // опционально: id как value

                if (db.Teachers.ToList().Count > 0)
                {
                    Teacher? selected = (Teacher?)comboBox2.SelectedItem;
                    int selectedId = db.Teachers.ToList()[0].Id;
                    if (selected != null)
                    {
                        selectedId = selected.Id;
                    }
                    comboBox2.DataSource = db.Teachers.ToList();
                    comboBox2.DisplayMember = "Name";
                    comboBox2.ValueMember = "Id";
                    comboBox2.SelectedValue = selectedId;
                    RefreshHistoty();
                }
                dataGridView4.Rows.Clear();
                dataGridView5.Rows.Clear();
                foreach (var t in teachers)
                {

                    dataGridView5.Rows.Add(t.Id, $"{t.TeacherType.Name} | {t.Name} \n{t.Phone}", $"{t.TeachersCources?.Count ?? 0} курсов");
                }
                foreach (var t in teachers)
                {

                    dataGridView4.Rows.Add(t.Id, $"{t.TeacherType.Name} | {t.Name} \n{t.Phone}", $"{t.TeachersCources?.Count ?? 0} курсов");
                }

            }
        }

        public void RefreshHistoty()
        {
            using (var db = new Context())
            {
                if (db.Teachers.ToList().Count > 0)
                {
                    Teacher? selected = (Teacher?)comboBox2.SelectedItem;
                    int selectedId = db.Teachers.ToList()[0].Id;
                    if (selected != null)
                    {
                        selectedId = selected.Id;
                    }
                    var history = db.TeacherCources.Include(t => t.Teacher).Include(t => t.Cource).ToList();
                    dataGridView3.Rows.Clear();
                    foreach (var t in history)
                    {
                        if (t.Teacher.Id == selectedId)
                        {
                            dataGridView3.Rows.Add(t.Cource.Name);
                        }
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using var db = new Context();
                if (db.TeacherTypes.FirstOrDefault(p => p.Name == textBox3.Text) is null)
                {
                    var teacherType = new TeacherType
                    {
                        Name = textBox3.Text
                    };
                    db.TeacherTypes.Add(teacherType);
                    db.SaveChanges();
                }
                var teacherTypeId = db.TeacherTypes.FirstOrDefault(p => p.Name == textBox3.Text).Id;
                var teacher = new Teacher
                {
                    Name = textBox1.Text,
                    Phone = textBox2.Text,
                    TeacherTypeId = teacherTypeId
                };
                db.Teachers.Add(teacher);
                db.SaveChanges();
                MessageBox.Show("Учитель добавлен!", "Круть!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при добавлении учителя.\nВсе поля должны быть заполнены.\nПроверьте корректность введенных данных и попробуйте снова.\nПодробности: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Context())
                {
                    var selectedId = (int?)comboBox1.SelectedValue;
                    if (selectedId != null)
                    {
                        if (db.TeacherTypes.FirstOrDefault(t => t.Name == textBox6.Text) is null)
                        {
                            var teacherType = new TeacherType
                            {
                                Name = textBox6.Text
                            };
                            db.TeacherTypes.Add(teacherType);
                            db.SaveChanges();
                        }
                        var teacherTypeId = db.TeacherTypes.FirstOrDefault(t => t.Name == textBox6.Text).Id;
                        var updated = db.Teachers.FirstOrDefault(t => t.Id == selectedId);
                        updated.Name = textBox4.Text;
                        updated.Phone = textBox5.Text;
                        updated.TeacherTypeId = teacherTypeId;
                        db.SaveChanges();
                        MessageBox.Show("Учитель успешно обновлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Teacher? selected = (Teacher?)comboBox1.SelectedItem;
                        if (selected != null)
                        {
                            selectedId = selected.Id;
                        }
                        comboBox1.DataSource = db.Teachers.Include(t => t.TeacherType).ToList(); // сбрасываем источник данных
                        comboBox1.DisplayMember = "Name";     // что отображать
                        comboBox1.ValueMember = "Id";         // опционально: id как value
                        comboBox1.SelectedValue = selectedId;
                        UpdateTeacherLoad();
                    }
                }
            }

            catch
            {

            }
        }

        public void UpdateTeacherLoad()
        {
            if (comboBox1.SelectedItem is Teacher selected)
            {
                using (var db = new Context())
                {
                    var fullTeacher = db.Teachers
                        .Include(t => t.TeacherType)
                        .FirstOrDefault(t => t.Id == selected.Id);

                    if (fullTeacher != null)
                    {
                        textBox4.Text = fullTeacher.Name;
                        textBox5.Text = fullTeacher.Phone;
                        textBox6.Text = fullTeacher.TeacherType.Name;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshTeachers();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateTeacherLoad();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshHistoty();
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = (int?)dataGridView4.SelectedRows[0].Cells["ID"].Value;
            if (id != null)
            {
                using (var db = new Context())
                {
                    comboBox1.SelectedValue = id;
                }
            }
        }

        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = (int?)dataGridView5.SelectedRows[0].Cells["IDISH"].Value;
            if (id != null)
            {
                using (var db = new Context())
                {
                    comboBox1.SelectedValue = id;
                }
            }
        }
    }

    public class Cource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Long { get; set; }
        public List<TeacherCource> TeachersCources { get; set; }
    }

    public class TeacherType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
    }

    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int TeacherTypeId { get; set; }
        public TeacherType TeacherType { get; set; }
        public List<TeacherCource> TeachersCources { get; set; }
    }

    public class TeacherCource
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int CourceId { get; set; }
        public Cource Cource { get; set; }
    }



    public class Context : DbContext
    {       
        public DbSet<Cource> Cources { get; set; }
        public DbSet<TeacherType> TeacherTypes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCource> TeacherCources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("Host=localhost;Port=5432;Database=demoexx;Username=postgres;Password=drimik");
        }
    }   
}