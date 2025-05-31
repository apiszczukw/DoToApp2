using DoToApp2.Helpers;
using System.Collections.ObjectModel;

namespace DoToApp2.Models
{
    public class ToDoTaskManager
    {
        public static ObservableCollection<ToDoTask> Tasks;

        public static void SaveTasks()
        {
            XmlHelper.SerializeToXml(Tasks, Files.TasksFilePath);
        }

        public static void LoadTasks()
        {
            Tasks = XmlHelper.DeserializeToXml<ObservableCollection<ToDoTask>>(Files.TasksFilePath);
        }

        public static void AddNewTask(string name, string desc)
        {
            if (Tasks == null)
            {
                Tasks = new ObservableCollection<ToDoTask>()
                {
                    new ToDoTask() {
                        Id = 1,
                        Name = name,
                        Desc = desc
                    }
                };
            }
            else
            {
                Tasks.Add(new ToDoTask()
                {
                    Id = Tasks.Max(t => t.Id) + 1,
                    Name = name,
                    Desc = desc
                });
            }

            SaveTasks();
        }

        public static void AddTestData()
        {
            if (File.Exists(Files.TasksFilePath)) 
                return;


            if (Tasks == null)
            {
                Tasks = new ObservableCollection<ToDoTask>()
                    {
                        new ToDoTask()
                        {
                            Id = 1,
                            Name = "Zrobić zakupy",
                            Desc = "Kupić mleko, chleb, jajka i warzywa na obiad"
                        },
                        new ToDoTask()
                        {
                            Id = 2,
                            Name = "Przygotować prezentację",
                            Desc = "Skończyć slajdy do prezentacji o interfejsach mózg-komputer"
                        },
                        new ToDoTask()
                        {
                            Id = 3,
                            Name = "Odpisać na maile",
                            Desc = "Odpowiedzieć studentom na pytania dotyczące projektu zaliczeniowego"
                        },
                        new ToDoTask()
                        {
                            Id = 4,
                            Name = "Wyjść na spacer z kotem",
                            Desc = "Zabrać Narkana na spacer z koszykiem rowerowym"
                        },
                        new ToDoTask()
                        {
                            Id = 5,
                            Name = "Zrobić backup danych",
                            Desc = "Utworzyć kopię zapasową folderu z projektami do chmury"
                        }
                    };

            }

            SaveTasks();
        }
    }
}
