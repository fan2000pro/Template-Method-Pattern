using System;

namespace ReportingSystem
{
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            CollectData();
            ProcessData();
            FormatReport();
            ExportReport();
        }

        protected abstract void CollectData();
        protected abstract void ProcessData();
        protected abstract void FormatReport();
        protected abstract void ExportReport();
    }

    public class StudentReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Сбор данных о студентах.");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработка данных о студентах.");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Форматирование отчета о студентах.");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Экспорт отчета о студентах.");
        }
    }

    public class CourseReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Сбор данных о курсах.");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработка данных о курсах.");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Форматирование отчета о курсах.");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Экспорт отчета о курсах.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Генерация отчета по студентам:");
            ReportGenerator studentReport = new StudentReportGenerator();
            studentReport.GenerateReport();

            Console.WriteLine("\nГенерация отчета по курсам:");
            ReportGenerator courseReport = new CourseReportGenerator();
            courseReport.GenerateReport();
        }
    }
}
