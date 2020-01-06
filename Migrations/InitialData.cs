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
    }
}