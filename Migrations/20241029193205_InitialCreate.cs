using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Presidents.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BirthPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirthPlaces", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MiddleName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DateOfDeath = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PresidentialAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PublicOfficeId = table.Column<int>(type: "int", nullable: false),
                    PartyId = table.Column<int>(type: "int", nullable: false),
                    StartDay = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EndDay = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresidentialAppointments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PreviousExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PublicOfficeId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    StartDay = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EndDay = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousExperiences", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PublicOffices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicOffices", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CapitalName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Population = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VicePresidentAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PresidentId = table.Column<int>(type: "int", nullable: false),
                    VicePresidentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VicePresidentAppointments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "CityName", "PersonId", "StateId" },
                values: new object[] { 1, "Popes Creek", 1, 46 });

            migrationBuilder.InsertData(
                table: "Parties",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[,]
                {
                    { 1, "Blue", "Democratic Party" },
                    { 2, "Red", "Republican Party" },
                    { 3, "Brown", "Whig Party" },
                    { 4, "Yellow", "Federalist Party" },
                    { 5, "Dark Blue", "Democratic-Republican Party" },
                    { 6, "Grey", "Independent" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "DateOfBirth", "DateOfDeath", "FirstName", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { 1, new DateTime(1732, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1799, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", "Washington", null },
                    { 2, new DateTime(1735, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1826, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Adams", null },
                    { 3, new DateTime(1743, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1826, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", "Jefferson", null },
                    { 4, new DateTime(1751, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1836, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", "Madison", null },
                    { 5, new DateTime(1758, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1831, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", "Monroe", null },
                    { 6, new DateTime(1767, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1848, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Quincy Adams", "Quincy" },
                    { 7, new DateTime(1767, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1845, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", "Jackson", null },
                    { 8, new DateTime(1782, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1862, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", "Van Buren", null },
                    { 9, new DateTime(1773, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1841, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "Harrison", "Henry" },
                    { 10, new DateTime(1790, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1862, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Tyler", null },
                    { 11, new DateTime(1795, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1849, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", "Polk", "Know" },
                    { 12, new DateTime(1784, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1850, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary", "Taylor", null },
                    { 13, new DateTime(1800, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1874, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Millard", "Fillmore", null },
                    { 14, new DateTime(1804, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1869, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franklin", "Pierce", null },
                    { 15, new DateTime(1791, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1868, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", "Buchanan", null },
                    { 16, new DateTime(1809, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1865, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abraham", "Lincoln", null },
                    { 17, new DateTime(1808, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1875, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", "Johnson", null },
                    { 18, new DateTime(1822, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1885, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ulysses", "Grant", "S." },
                    { 19, new DateTime(1822, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1893, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutherford", "Hayes", "Birchard" },
                    { 20, new DateTime(1831, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1881, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", "Garfield", "Abram" },
                    { 21, new DateTime(1829, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1886, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chester", "Arthur", "Alan" },
                    { 22, new DateTime(1837, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1908, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grover", "Cleveland", "Cleveland" },
                    { 23, new DateTime(1833, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1901, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", "Harrison", null },
                    { 25, new DateTime(1843, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1901, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "McKinley", null },
                    { 26, new DateTime(1858, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1919, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theodore", "Roosevelt", null },
                    { 27, new DateTime(1857, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1930, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "Taft", "Howard" },
                    { 28, new DateTime(1856, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1924, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Woodrow", "Wilson", null },
                    { 29, new DateTime(1865, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1923, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warren", "Harding", "Gamaliel" },
                    { 30, new DateTime(1872, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1933, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Calvin", "Coolidge", null },
                    { 31, new DateTime(1874, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Herbert", "Hoover", "Clark" },
                    { 32, new DateTime(1882, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1945, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franklin", "Roosevelt", "Delano" },
                    { 33, new DateTime(1884, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry", "Truman", "S." },
                    { 34, new DateTime(1890, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dwight", "Eisenhower", "David" },
                    { 35, new DateTime(1917, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Kennedy", "Fitzgerald" },
                    { 36, new DateTime(1908, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lyndon", "Johnson", "Baines" },
                    { 37, new DateTime(1913, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richard", "Nixon", "Milhous" },
                    { 38, new DateTime(1913, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerald", "Ford", "Rudolph" },
                    { 39, new DateTime(1924, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jimmy", "Carter", "Carter" },
                    { 40, new DateTime(1911, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ronald", "Reagan", "Wilson" },
                    { 41, new DateTime(1924, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", "Bush", "Herbert Walker" },
                    { 42, new DateTime(1946, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "William", "Clinton", "Jefferson" },
                    { 43, new DateTime(1946, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "George", "Bush", "Walker" },
                    { 44, new DateTime(1961, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Barack", "Obama", "Hussein" },
                    { 45, new DateTime(1946, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Donald", "Trump", "John" },
                    { 46, new DateTime(1942, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joseph", "Biden", "Robinette" },
                    { 49, new DateTime(1756, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1836, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaron", "Burr", null },
                    { 50, new DateTime(1739, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1812, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", "Clinton", null },
                    { 51, new DateTime(1744, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1814, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elbridge", "Gerry", null },
                    { 52, new DateTime(1774, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1825, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "Tompkins", "D." },
                    { 53, new DateTime(1782, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1850, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Calhoun", "Caldwell" },
                    { 55, new DateTime(1780, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1850, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richard", "Johnson", "Mentor" },
                    { 57, new DateTime(1792, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1864, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", "Dallas", null },
                    { 59, new DateTime(1786, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1853, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "King", "Rufus DeVane" },
                    { 60, new DateTime(1821, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1875, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Breckinridge", null },
                    { 61, new DateTime(1809, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1891, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hannibal", "Hamlin", null },
                    { 63, new DateTime(1823, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1885, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schuyler", "Colfax", null },
                    { 64, new DateTime(1812, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1875, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", "Wilson", "Wilson" },
                    { 65, new DateTime(1819, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1887, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "Wheeler", "A." },
                    { 67, new DateTime(1819, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1885, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", "Hendricks", "Andrews" },
                    { 68, new DateTime(1824, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1920, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Levi", "Morton", "Parsons" },
                    { 69, new DateTime(1835, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1914, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adlai", "Stevenson", "Ewing" },
                    { 70, new DateTime(1844, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garret", "Hobart", "Augustus" },
                    { 72, new DateTime(1852, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1918, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", "Fairbanks", "Warren" },
                    { 73, new DateTime(1855, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1912, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", "Sherman", "Schoolcraft" },
                    { 74, new DateTime(1854, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1925, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", "Marshall", "Riley" },
                    { 76, new DateTime(1865, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", "Dawes", "Gates" },
                    { 77, new DateTime(1860, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1936, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", "Curtis", null },
                    { 78, new DateTime(1868, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Garner", "Nance" },
                    { 79, new DateTime(1888, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", "Wallace", "Agard" },
                    { 81, new DateTime(1877, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alben", "Barkley", null },
                    { 84, new DateTime(1911, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hubert", "Humphrey", "Horatio" },
                    { 85, new DateTime(1918, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spiro", "Agnew", null },
                    { 86, new DateTime(1913, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerald", "Ford", null },
                    { 87, new DateTime(1908, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", "Rockefeller", "Aldrich" },
                    { 88, new DateTime(1928, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Walter", "Mondale", "Frederick" },
                    { 90, new DateTime(1947, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dan", "Quayle", "Robert" },
                    { 91, new DateTime(1948, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", "Gore", "Arnold" },
                    { 92, new DateTime(1941, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dick", "Cheney", "Cheney" },
                    { 94, new DateTime(1959, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mike", "Pence", "Richard" },
                    { 95, new DateTime(1964, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kamala", "Harris", "Devi" }
                });

            migrationBuilder.InsertData(
                table: "PresidentialAppointments",
                columns: new[] { "Id", "EndDay", "PartyId", "PersonId", "PublicOfficeId", "StartDay" },
                values: new object[,]
                {
                    { 1, new DateTime(1797, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1, new DateTime(1789, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1801, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, 1, new DateTime(1797, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1809, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, 1, new DateTime(1801, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1817, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, 1, new DateTime(1809, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1825, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, 1, new DateTime(1817, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1829, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 6, 1, new DateTime(1825, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1837, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 7, 1, new DateTime(1829, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1841, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, 1, new DateTime(1837, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1841, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9, 1, new DateTime(1841, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1845, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10, 1, new DateTime(1841, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1849, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 11, 1, new DateTime(1845, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(1850, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 12, 1, new DateTime(1849, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(1853, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 13, 1, new DateTime(1850, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(1857, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 14, 1, new DateTime(1853, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(1861, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 15, 1, new DateTime(1857, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(1865, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 16, 1, new DateTime(1861, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(1869, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 17, 1, new DateTime(1865, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(1877, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 18, 1, new DateTime(1869, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(1881, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 19, 1, new DateTime(1877, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(1881, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 20, 1, new DateTime(1881, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(1885, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 21, 1, new DateTime(1881, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(1889, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 22, 1, new DateTime(1885, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(1893, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 23, 1, new DateTime(1889, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(1897, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 22, 1, new DateTime(1893, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(1901, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 25, 1, new DateTime(1897, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(1909, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 26, 1, new DateTime(1901, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(1913, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 27, 1, new DateTime(1909, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(1921, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 28, 1, new DateTime(1913, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(1923, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 29, 1, new DateTime(1921, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(1929, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 30, 1, new DateTime(1923, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(1933, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 31, 1, new DateTime(1929, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(1945, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 32, 1, new DateTime(1933, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(1953, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 33, 1, new DateTime(1945, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(1961, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 34, 1, new DateTime(1953, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(1963, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 35, 1, new DateTime(1961, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(1969, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 36, 1, new DateTime(1963, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 37, 1, new DateTime(1969, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(1977, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 38, 1, new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 39, 1, new DateTime(1977, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(1989, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 40, 1, new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(1993, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 41, 1, new DateTime(1989, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2001, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 42, 1, new DateTime(1993, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2009, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 43, 1, new DateTime(2001, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2017, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 44, 1, new DateTime(2009, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 45, 1, new DateTime(2017, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, null, 1, 46, 1, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(1797, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, 2, new DateTime(1789, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(1801, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, 2, new DateTime(1797, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(1805, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 49, 2, new DateTime(1801, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(1812, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 50, 2, new DateTime(1805, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(1814, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 51, 2, new DateTime(1814, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(1825, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 52, 2, new DateTime(1817, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(1832, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 53, 2, new DateTime(1825, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(1837, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, 2, new DateTime(1833, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(1841, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 55, 2, new DateTime(1837, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(1841, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10, 2, new DateTime(1841, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(1849, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 57, 2, new DateTime(1845, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(1950, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 13, 2, new DateTime(1849, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(1853, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 59, 2, new DateTime(1853, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(1861, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 60, 2, new DateTime(1857, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(1865, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 61, 2, new DateTime(1861, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, new DateTime(1865, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 17, 2, new DateTime(1865, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(1873, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 63, 2, new DateTime(1869, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(1875, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 64, 2, new DateTime(1873, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(1881, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 65, 2, new DateTime(1877, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, new DateTime(1881, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 21, 2, new DateTime(1881, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, new DateTime(1885, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 67, 2, new DateTime(1885, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(1893, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 68, 2, new DateTime(1889, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(1897, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 69, 2, new DateTime(1893, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(1899, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 70, 2, new DateTime(1897, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(1901, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 26, 2, new DateTime(1901, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(1909, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 72, 2, new DateTime(1905, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, new DateTime(1912, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 73, 2, new DateTime(1909, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, new DateTime(1921, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 74, 2, new DateTime(1913, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, new DateTime(1923, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 30, 2, new DateTime(1921, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, new DateTime(1929, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 76, 2, new DateTime(1925, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, new DateTime(1933, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 77, 2, new DateTime(1929, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, new DateTime(1941, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 78, 2, new DateTime(1933, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, new DateTime(1945, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 79, 2, new DateTime(1941, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, new DateTime(1945, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 33, 2, new DateTime(1945, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, new DateTime(1953, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 81, 2, new DateTime(1949, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, new DateTime(1961, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 37, 2, new DateTime(1953, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, new DateTime(1963, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 36, 2, new DateTime(1961, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, new DateTime(1969, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 84, 2, new DateTime(1965, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, new DateTime(1973, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 85, 2, new DateTime(1969, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 38, 2, new DateTime(1973, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, new DateTime(1977, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 87, 2, new DateTime(1974, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 88, 2, new DateTime(1977, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, new DateTime(1989, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 41, 2, new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, new DateTime(1993, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 90, 2, new DateTime(1989, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, new DateTime(2001, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 91, 2, new DateTime(1993, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, new DateTime(2009, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 92, 2, new DateTime(2001, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, new DateTime(2017, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 46, 2, new DateTime(2009, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 94, 2, new DateTime(2017, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, null, 1, 95, 2, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "PreviousExperiences",
                columns: new[] { "Id", "EndDay", "PersonId", "PublicOfficeId", "StartDay", "StateId" },
                values: new object[] { 1, new DateTime(1783, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(1775, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.InsertData(
                table: "PublicOffices",
                columns: new[] { "Id", "Role" },
                values: new object[,]
                {
                    { 1, "General" },
                    { 2, "Senator" },
                    { 3, "Representative" },
                    { 4, "Governor" },
                    { 5, "Mayor" },
                    { 6, "Judge" },
                    { 7, "Delegate" },
                    { 8, "Secretary" },
                    { 9, "Not in a public office" },
                    { 10, "President" },
                    { 11, "Vice President" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "CapitalName", "Name", "Population" },
                values: new object[,]
                {
                    { 1, "Montgomery", "Alabama", 5024279 },
                    { 2, "Juneau", "Alaska", 733391 },
                    { 3, "Phoenix", "Arizona", 7151502 },
                    { 4, "Little Rock", "Arkansas", 3011524 },
                    { 5, "Sacramento", "California", 39538223 },
                    { 6, "Denver", "Colorado", 5773714 },
                    { 7, "Hartford", "Connecticut", 3596080 },
                    { 8, "Dover", "Delaware", 989948 },
                    { 9, "Tallahassee", "Florida", 21538187 },
                    { 10, "Atlanta", "Georgia", 10711908 },
                    { 11, "Honolulu", "Hawaii", 1455271 },
                    { 12, "Boise", "Idaho", 1839106 },
                    { 13, "Springfield", "Illinois", 12812508 },
                    { 14, "Indianapolis", "Indiana", 6785528 },
                    { 15, "Des Moines", "Iowa", 3190369 },
                    { 16, "Topeka", "Kansas", 2913314 },
                    { 17, "Frankfort", "Kentucky", 4505836 },
                    { 18, "Baton Rouge", "Louisiana", 4657757 },
                    { 19, "Augusta", "Maine", 1364211 },
                    { 20, "Annapolis", "Maryland", 6187428 },
                    { 21, "Boston", "Massachusetts", 7029917 },
                    { 22, "Lansing", "Michigan", 10077331 },
                    { 23, "St. Paul", "Minnesota", 5706494 },
                    { 24, "Jackson", "Mississippi", 2961279 },
                    { 25, "Jefferson City", "Missouri", 6154913 },
                    { 26, "Helena", "Montana", 1084225 },
                    { 27, "Lincoln", "Nebraska", 1961504 },
                    { 28, "Carson City", "Nevada", 3104614 },
                    { 29, "Concord", "New Hampshire", 1377529 },
                    { 30, "Trenton", "New Jersey", 9288994 },
                    { 31, "Santa Fe", "New Mexico", 2117522 },
                    { 32, "Albany", "New York", 20201249 },
                    { 33, "Raleigh", "North Carolina", 10439388 },
                    { 34, "Bismarck", "North Dakota", 779094 },
                    { 35, "Columbus", "Ohio", 11799448 },
                    { 36, "Oklahoma City", "Oklahoma", 3963516 },
                    { 37, "Salem", "Oregon", 4237256 },
                    { 38, "Harrisburg", "Pennsylvania", 13002700 },
                    { 39, "Providence", "Rhode Island", 1097379 },
                    { 40, "Columbia", "South Carolina", 5118425 },
                    { 41, "Pierre", "South Dakota", 887770 },
                    { 42, "Nashville", "Tennessee", 6910840 },
                    { 43, "Austin", "Texas", 29145505 },
                    { 44, "Salt Lake City", "Utah", 3271616 },
                    { 45, "Montpelier", "Vermont", 643077 },
                    { 46, "Richmond", "Virginia", 8631393 },
                    { 47, "Olympia", "Washington", 7693612 },
                    { 48, "Charleston", "West Virginia", 1784780 },
                    { 49, "Madison", "Wisconsin", 5893718 },
                    { 50, "Cheyenne", "Wyoming", 576851 }
                });

            migrationBuilder.InsertData(
                table: "VicePresidentAppointments",
                columns: new[] { "Id", "PresidentId", "VicePresidentId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 3 },
                    { 3, 3, 49 },
                    { 4, 3, 50 },
                    { 5, 4, 50 },
                    { 6, 4, 51 },
                    { 7, 5, 52 },
                    { 8, 6, 53 },
                    { 9, 7, 53 },
                    { 10, 7, 8 },
                    { 11, 8, 55 },
                    { 12, 9, 10 },
                    { 13, 11, 57 },
                    { 14, 12, 13 },
                    { 15, 14, 59 },
                    { 16, 15, 60 },
                    { 17, 16, 61 },
                    { 18, 16, 17 },
                    { 19, 18, 63 },
                    { 20, 18, 64 },
                    { 21, 19, 65 },
                    { 22, 20, 21 },
                    { 23, 22, 67 },
                    { 24, 23, 68 },
                    { 25, 22, 69 },
                    { 26, 25, 70 },
                    { 27, 25, 26 },
                    { 28, 26, 72 },
                    { 29, 27, 73 },
                    { 30, 28, 74 },
                    { 31, 29, 30 },
                    { 32, 30, 76 },
                    { 33, 31, 77 },
                    { 34, 32, 78 },
                    { 35, 32, 79 },
                    { 36, 32, 33 },
                    { 37, 33, 81 },
                    { 38, 34, 37 },
                    { 39, 35, 36 },
                    { 40, 36, 84 },
                    { 41, 37, 85 },
                    { 42, 37, 38 },
                    { 43, 38, 87 },
                    { 44, 39, 88 },
                    { 45, 40, 41 },
                    { 46, 41, 90 },
                    { 47, 42, 91 },
                    { 48, 43, 92 },
                    { 49, 44, 46 },
                    { 50, 45, 94 },
                    { 51, 46, 95 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BirthPlaces");

            migrationBuilder.DropTable(
                name: "Parties");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "PresidentialAppointments");

            migrationBuilder.DropTable(
                name: "PreviousExperiences");

            migrationBuilder.DropTable(
                name: "PublicOffices");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "VicePresidentAppointments");
        }
    }
}
