using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.Migrations
{
    public static class InitialData
    {
        public static void addCleanYear(MigrationBuilder migrationBuilder, int year, int firstDayNoInFirstWeek, int daysInYear){
            migrationBuilder.Sql("INSERT INTO Schedules (Name) VALUES ('Szkoła językowa')");
            migrationBuilder.Sql("INSERT INTO YearlyPlans (Name, ScheduleId) VALUES ('" + year.ToString() + "', (SELECT ID FROM Schedules WHERE Name = 'Szkoła językowa'))");
            migrationBuilder.Sql("INSERT INTO MonthlyPlans (Name, YearlyPlanId) VALUES ('Styczeń', (SELECT ID FROM YearlyPlans WHERE Name = '" + year.ToString() + "'))");
            migrationBuilder.Sql("INSERT INTO MonthlyPlans (Name, YearlyPlanId) VALUES ('Luty', (SELECT ID FROM YearlyPlans WHERE Name = '" + year.ToString() + "'))");
            migrationBuilder.Sql("INSERT INTO MonthlyPlans (Name, YearlyPlanId) VALUES ('Marzec', (SELECT ID FROM YearlyPlans WHERE Name = '" + year.ToString() + "'))");
            int day = 1;
            int week = 1;
            int weekDay = firstDayNoInFirstWeek;
            
            migrationBuilder.Sql("INSERT INTO WeeklyPlans (Name, MonthlyPlanId) VALUES ('" + week.ToString() + "', (SELECT ID FROM MonthlyPlans WHERE Name = 'Styczeń'))");
            
            for (int i=1; i<=31; i++){
                migrationBuilder.Sql("INSERT INTO DailyPlans (DayNoInWeek, DayNo, WeeklyPlanId) VALUES ("+ weekDay + ", " + day.ToString() + ", (SELECT ID FROM WeeklyPlans WHERE Name = '" + week.ToString() + "'))");
                weekDay++;
                day++;
                if(weekDay > 7){
                    weekDay = 1;
                    week++;
                    migrationBuilder.Sql("INSERT INTO WeeklyPlans (Name, MonthlyPlanId) VALUES ('" + week.ToString() + "', (SELECT ID FROM MonthlyPlans WHERE Name = 'Styczeń'))");
                }
            }
            for (int i=1; i<=29; i++){
                migrationBuilder.Sql("INSERT INTO DailyPlans (DayNoInWeek, DayNo, WeeklyPlanId) VALUES ("+ weekDay + ", " + day.ToString() + ", (SELECT ID FROM WeeklyPlans WHERE Name = '" + week.ToString() + "'))");
                weekDay++;
                day++;
                if(weekDay > 7){
                    weekDay = 1;
                    week++;
                    migrationBuilder.Sql("INSERT INTO WeeklyPlans (Name, MonthlyPlanId) VALUES ('" + week.ToString() + "', (SELECT ID FROM MonthlyPlans WHERE Name = 'Luty'))");
                }
            }                
            for (int i=1; i<=31; i++){
                migrationBuilder.Sql("INSERT INTO DailyPlans (DayNoInWeek, DayNo, WeeklyPlanId) VALUES ("+ weekDay + ", " + day.ToString() + ", (SELECT ID FROM WeeklyPlans WHERE Name = '" + week.ToString() + "'))");
                weekDay++;
                day++;
                if(weekDay > 7){
                    weekDay = 1;
                    week++;
                    migrationBuilder.Sql("INSERT INTO WeeklyPlans (Name, MonthlyPlanId) VALUES ('" + week.ToString() + "', (SELECT ID FROM MonthlyPlans WHERE Name = 'Marzec'))");
                }
            }
            
        }
        public static void addRooms(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Rooms (Name) VALUES ('Sala lekcyjna 1')");
            migrationBuilder.Sql("INSERT INTO Rooms (Name) VALUES ('Sala lekcyjna 2')");
            migrationBuilder.Sql("INSERT INTO Rooms (Name) VALUES ('Sala lekcyjna 3')");
            migrationBuilder.Sql("INSERT INTO Rooms (Name) VALUES ('Duża aula')");
            migrationBuilder.Sql("INSERT INTO Rooms (Name) VALUES ('Mała aula')");
        }
        public static void addLanguages(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Languages (Name) VALUES ('Angielski')");
            migrationBuilder.Sql("INSERT INTO Languages (Name) VALUES ('Niemiecki')");
            migrationBuilder.Sql("INSERT INTO Languages (Name) VALUES ('Hiszpański')");
        }
        public static void addInstructors(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Jon', 'Kovalsky')");
            migrationBuilder.Sql("INSERT INTO Instructors (Login, PersonId, LanguageId) VALUES ('kowal', (SELECT ID FROM Persons WHERE FirstName = 'Jon'), (SELECT ID FROM Languages WHERE Name = 'Angielski'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Anastazja', 'Frywolna')");
            migrationBuilder.Sql("INSERT INTO Instructors (Login, PersonId, LanguageId) VALUES ('stazja', (SELECT ID FROM Persons WHERE FirstName = 'Anastazja'), (SELECT ID FROM Languages WHERE Name = 'Niemiecki'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Angela', 'Pazz')");
            migrationBuilder.Sql("INSERT INTO Instructors (Login, PersonId, LanguageId) VALUES ('angel', (SELECT ID FROM Persons WHERE FirstName = 'Angela'), (SELECT ID FROM Languages WHERE Name = 'Hiszpański'))");
        }

        public static void addStudents(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Jan', 'Kowalski')");
            migrationBuilder.Sql("INSERT INTO Students (Login, PersonId) VALUES ('jan23', (SELECT ID FROM Persons WHERE FirstName = 'Jan'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Stefan', 'Dolny')");
            migrationBuilder.Sql("INSERT INTO Students (Login, PersonId) VALUES ('stefanZ', (SELECT ID FROM Persons WHERE FirstName = 'Stefan'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Iza', 'Polna')");
            migrationBuilder.Sql("INSERT INTO Students (Login, PersonId) VALUES ('izolka', (SELECT ID FROM Persons WHERE FirstName = 'Iza'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Anna', 'Topa')");
            migrationBuilder.Sql("INSERT INTO Students (Login, PersonId) VALUES ('aaaaa', (SELECT ID FROM Persons WHERE FirstName = 'Anna'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Agata', 'Polna')");
            migrationBuilder.Sql("INSERT INTO Students (Login, PersonId) VALUES ('aga25', (SELECT ID FROM Persons WHERE FirstName = 'Agata'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Marlena', 'Patena')");
            migrationBuilder.Sql("INSERT INTO Students (Login, PersonId) VALUES ('zolza', (SELECT ID FROM Persons WHERE FirstName = 'Marlena'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Adam', 'Wolny')");
            migrationBuilder.Sql("INSERT INTO Students (Login, PersonId) VALUES ('aban', (SELECT ID FROM Persons WHERE FirstName = 'Adam'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Marek', 'Bok')");
            migrationBuilder.Sql("INSERT INTO Students (Login, PersonId) VALUES ('matarek', (SELECT ID FROM Persons WHERE FirstName = 'Marek'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Jola', 'Stefańska')");
            migrationBuilder.Sql("INSERT INTO Students (Login, PersonId) VALUES ('jojo', (SELECT ID FROM Persons WHERE FirstName = 'Jola'))");
            migrationBuilder.Sql("INSERT INTO Persons (FirstName, LastName) VALUES ('Wiola', 'Markowska')");
            migrationBuilder.Sql("INSERT INTO Students (Login, PersonId) VALUES ('wiolka', (SELECT ID FROM Persons WHERE FirstName = 'Wiola'))");
        }
    }
}