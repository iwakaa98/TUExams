using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TUExams.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    ExamHall = table.Column<int>(nullable: false),
                    CourseId = table.Column<string>(nullable: true),
                    FacultyId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exams_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Number" },
                values: new object[,]
                {
                    { "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", 1 },
                    { "d2d35048-1d12-4621-82d1-5529d7563c2f", 2 },
                    { "41aee425-0155-42c0-a684-7b942c10a96a", 3 },
                    { "8ffa306b-e326-4752-9035-d060827f392d", 4 }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "c8469f21-1cc6-4bc5-892e-933b5be61799", "Факултет по Компютърни Системи и Технологии" },
                    { "054b0bce-5068-4788-83a3-b0a4828709a6", "Факултет по ТелеКомуникации" },
                    { "462814e1-f72b-48cb-ab1a-3abe5663b9a7", "Машино-Технологичен Факултет" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CourseId", "Date", "Description", "Duration", "ExamHall", "FacultyId", "Title" },
                values: new object[,]
                {
                    { "55f7dc5f-c803-42ab-8ea6-73828fb71182", "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", new DateTime(2020, 1, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 180, 1152, "c8469f21-1cc6-4bc5-892e-933b5be61799", "Физика 1 " },
                    { "3aa4ff5d-d351-451f-8075-c6a30a5fc271", "41aee425-0155-42c0-a684-7b942c10a96a", new DateTime(2020, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), null, 150, 4112, "462814e1-f72b-48cb-ab1a-3abe5663b9a7", "Производствени технологии 1" },
                    { "016fb3f9-3895-4b19-93eb-0acf110fbbd5", "41aee425-0155-42c0-a684-7b942c10a96a", new DateTime(2020, 1, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 120, 3425, "462814e1-f72b-48cb-ab1a-3abe5663b9a7", "Производствени машини" },
                    { "5a48e827-c608-4064-958c-02b7dd72ebc9", "d2d35048-1d12-4621-82d1-5529d7563c2f", new DateTime(2020, 1, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 90, 3312, "462814e1-f72b-48cb-ab1a-3abe5663b9a7", "Машинознание 2" },
                    { "7fc6ca56-f6d8-48d5-9e6e-725919dcec5c", "d2d35048-1d12-4621-82d1-5529d7563c2f", new DateTime(2020, 1, 27, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 180, 2140, "462814e1-f72b-48cb-ab1a-3abe5663b9a7", "Математика 2" },
                    { "170409b5-70b9-41ef-8ec9-59618da4773c", "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", new DateTime(2020, 1, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 180, 2140, "462814e1-f72b-48cb-ab1a-3abe5663b9a7", "Физика 1" },
                    { "01926095-1133-4f6f-884b-c5dafd7abfe8", "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", new DateTime(2020, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), null, 180, 2130, "462814e1-f72b-48cb-ab1a-3abe5663b9a7", "Математика 1" },
                    { "08f2c18e-ed0d-48d5-8be7-a3f2d0e48018", "8ffa306b-e326-4752-9035-d060827f392d", new DateTime(2020, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), null, 120, 2512, "054b0bce-5068-4788-83a3-b0a4828709a6", "Транспортни телекомуникационни мрежи" },
                    { "ac9b1767-b8c7-4e2e-88a9-b0df33c8d65f", "8ffa306b-e326-4752-9035-d060827f392d", new DateTime(2020, 1, 22, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 150, 1154, "054b0bce-5068-4788-83a3-b0a4828709a6", "Микропроцесорна техника" },
                    { "e221588c-45f3-4807-9d15-9bc10ed731a2", "41aee425-0155-42c0-a684-7b942c10a96a", new DateTime(2020, 1, 21, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 60, 10213, "054b0bce-5068-4788-83a3-b0a4828709a6", "Полупроводникови елементи" },
                    { "32887b05-5e27-4cf6-9538-57d10d30640a", "41aee425-0155-42c0-a684-7b942c10a96a", new DateTime(2020, 1, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), null, 180, 1152, "054b0bce-5068-4788-83a3-b0a4828709a6", "Програмиране и използвнае на компютри 3" },
                    { "cdab35bc-fdb7-4811-803d-2cf305e78523", "d2d35048-1d12-4621-82d1-5529d7563c2f", new DateTime(2020, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), null, 120, 4341, "054b0bce-5068-4788-83a3-b0a4828709a6", "Електрически измервания" },
                    { "21a11635-216a-489c-a7ff-e8aa5fea6780", "d2d35048-1d12-4621-82d1-5529d7563c2f", new DateTime(2020, 2, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 120, 12318, "054b0bce-5068-4788-83a3-b0a4828709a6", "Теоретична електротехника" },
                    { "785a291d-b4c3-42f3-a949-c09b8f676719", "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", new DateTime(2020, 1, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 180, 2140, "054b0bce-5068-4788-83a3-b0a4828709a6", "Математика  1 " },
                    { "8fecb0b9-c0e3-418d-9243-60173db9b187", "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", new DateTime(2020, 1, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 180, 2130, "054b0bce-5068-4788-83a3-b0a4828709a6", "Физика 1 " },
                    { "0865d346-69fe-4866-8fe2-1f9611a84fe2", "8ffa306b-e326-4752-9035-d060827f392d", new DateTime(2020, 1, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), null, 90, 1152, "c8469f21-1cc6-4bc5-892e-933b5be61799", "Програмиране и използване на компютри 3" },
                    { "43bfdfb5-83d3-466f-be29-622962619744", "8ffa306b-e326-4752-9035-d060827f392d", new DateTime(2020, 1, 27, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 120, 2130, "c8469f21-1cc6-4bc5-892e-933b5be61799", "Бази от Данни" },
                    { "3b1028c0-0ef4-48ed-b748-881a6b218a32", "41aee425-0155-42c0-a684-7b942c10a96a", new DateTime(2020, 1, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 180, 2140, "c8469f21-1cc6-4bc5-892e-933b5be61799", "Физика 2" },
                    { "a905c64f-f2f6-43b2-9e04-0fc118e86be8", "41aee425-0155-42c0-a684-7b942c10a96a", new DateTime(2020, 1, 27, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 90, 12152, "c8469f21-1cc6-4bc5-892e-933b5be61799", "Програмиране и използване на компютри 2" },
                    { "2c8fa666-c8d9-495d-b116-efb61672eeb1", "d2d35048-1d12-4621-82d1-5529d7563c2f", new DateTime(2020, 1, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), null, 180, 2130, "c8469f21-1cc6-4bc5-892e-933b5be61799", "Математика 3" },
                    { "bde0cb83-2136-40f1-b592-3276c57e9284", "d2d35048-1d12-4621-82d1-5529d7563c2f", new DateTime(2020, 1, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 90, 1154, "c8469f21-1cc6-4bc5-892e-933b5be61799", "Химия " },
                    { "48619be3-aba2-4159-aef5-c9ebef9983f8", "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", new DateTime(2020, 1, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 180, 1153, "c8469f21-1cc6-4bc5-892e-933b5be61799", "Математика 1 " },
                    { "d0a1ffac-4497-49cb-805e-bb4e3b79be5a", "8ffa306b-e326-4752-9035-d060827f392d", new DateTime(2020, 1, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 180, 4137, "462814e1-f72b-48cb-ab1a-3abe5663b9a7", "Програмиране на CNC машини" },
                    { "e9060bbc-7a3a-44a2-9310-edb58be98f9b", "8ffa306b-e326-4752-9035-d060827f392d", new DateTime(2020, 1, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 90, 3620, "462814e1-f72b-48cb-ab1a-3abe5663b9a7", "Управление на жизнения цикъл на изделията" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CourseId",
                table: "Exams",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_FacultyId",
                table: "Exams",
                column: "FacultyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
