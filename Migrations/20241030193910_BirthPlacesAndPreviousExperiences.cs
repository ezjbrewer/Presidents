using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Presidents.Migrations
{
    /// <inheritdoc />
    public partial class BirthPlacesAndPreviousExperiences : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "BirthPlaces",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "CityName", "PersonId", "StateId" },
                values: new object[,]
                {
                    { 2, "Braintree", 2, 21 },
                    { 3, "Goochland", 3, 46 },
                    { 4, "Port Conway", 4, 46 },
                    { 5, "Monroe Hall", 5, 46 },
                    { 6, "Braintree", 6, 21 },
                    { 7, "Waxhaw Settlement", 7, 33 },
                    { 8, "Kinderhook", 8, 8 },
                    { 9, "Charles City County", 9, 46 },
                    { 10, "Charles City County", 10, 46 },
                    { 11, "Pineville", 11, 33 },
                    { 12, "Barboursville", 12, 46 },
                    { 13, "Moravia", 13, 32 },
                    { 14, "Hillsborough", 14, 29 },
                    { 15, "Cove Gap", 15, 38 },
                    { 16, "Sinkling Spring Farm", 16, 17 },
                    { 17, "Raleigh", 17, 33 },
                    { 18, "Point Pleasant", 18, 35 },
                    { 19, "Deleware", 19, 35 },
                    { 20, "Moreland Hills", 20, 35 },
                    { 21, "Fairfield", 21, 45 },
                    { 22, "Caldwell", 22, 30 },
                    { 23, "North Bend", 23, 35 },
                    { 25, "Niles", 25, 35 },
                    { 26, "New York City", 26, 32 },
                    { 27, "Cincinnati", 27, 35 },
                    { 28, "Staunton", 28, 46 },
                    { 29, "Blooming Grove", 29, 35 },
                    { 30, "Plymouth Notch", 30, 45 },
                    { 31, "West Branch", 31, 15 },
                    { 32, "Hyde Park", 32, 32 },
                    { 33, "Lamar", 33, 25 },
                    { 34, "Denison", 34, 43 },
                    { 35, "Brookline", 35, 21 },
                    { 36, "Gillespie County", 36, 43 },
                    { 37, "Yorba Linda", 37, 5 },
                    { 38, "Omaha", 38, 27 },
                    { 39, "Plains", 39, 10 },
                    { 40, "Tampico", 40, 13 },
                    { 41, "Milton", 41, 21 },
                    { 42, "Hope", 42, 4 },
                    { 43, "New Haven", 43, 7 },
                    { 44, "Honolulu", 44, 11 },
                    { 45, "New York City", 45, 32 },
                    { 46, "Scranton", 46, 38 },
                    { 47, "Newark", 49, 30 },
                    { 48, "Little Britain", 50, 32 },
                    { 49, "Marblehead", 51, 21 },
                    { 50, "Scarsdale", 52, 32 },
                    { 51, "Abbeville", 53, 40 },
                    { 52, "Louisville", 55, 17 },
                    { 53, "Philadelphia", 57, 38 },
                    { 54, "Sampson County", 59, 33 },
                    { 55, "Lexington", 60, 17 },
                    { 56, "Paris", 61, 19 },
                    { 57, "New York City", 63, 32 },
                    { 58, "Farmington", 64, 29 },
                    { 59, "Malone", 65, 32 },
                    { 60, "Fultonham", 67, 35 },
                    { 61, "Shoreham", 68, 45 },
                    { 62, "Christian County", 69, 17 },
                    { 63, "Long Branch", 70, 30 },
                    { 64, "Unionville Center", 72, 35 },
                    { 65, "Utica", 73, 32 },
                    { 66, "North Manchester", 74, 14 },
                    { 67, "Marietta", 76, 35 },
                    { 68, "North Topeka", 77, 16 },
                    { 69, "Red River County", 78, 43 },
                    { 70, "Orient", 79, 15 },
                    { 71, "Lowes", 81, 17 },
                    { 72, "Wallace", 84, 41 },
                    { 73, "Baltimore", 85, 20 },
                    { 74, "Bar Harbor", 87, 19 },
                    { 75, "Ceylon", 88, 23 },
                    { 76, "Indianapolis", 90, 14 },
                    { 77, "Washinton D.C.", 91, 46 },
                    { 78, "Lincoln", 92, 27 },
                    { 79, "Columbus", 94, 14 },
                    { 80, "Oakland", 95, 5 }
                });

            migrationBuilder.UpdateData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDay", "PublicOfficeId", "StartDay" },
                values: new object[] { new DateTime(1775, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(1774, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "PreviousExperiences",
                columns: new[] { "Id", "EndDay", "PersonId", "PublicOfficeId", "StartDay", "StateId" },
                values: new object[,]
                {
                    { 2, new DateTime(1783, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(1775, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 3, new DateTime(1777, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7, new DateTime(1774, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 4, new DateTime(1776, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, new DateTime(1775, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 5, new DateTime(1793, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8, new DateTime(1790, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 6, new DateTime(1783, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 7, new DateTime(1781, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 7, new DateTime(1787, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 7, new DateTime(1786, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 8, new DateTime(1797, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, new DateTime(1789, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 9, new DateTime(1808, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 8, new DateTime(1801, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 10, new DateTime(1786, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 7, new DateTime(1783, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 11, new DateTime(1794, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, new DateTime(1790, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 12, new DateTime(1802, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, new DateTime(1799, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 13, new DateTime(1811, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, new DateTime(1811, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 14, new DateTime(1817, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 8, new DateTime(1811, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 15, new DateTime(1815, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 8, new DateTime(1814, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 16, new DateTime(1808, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, new DateTime(1803, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 17, new DateTime(1848, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3, new DateTime(1831, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 18, new DateTime(1825, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 8, new DateTime(1817, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 19, new DateTime(1797, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, new DateTime(1796, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 20, new DateTime(1798, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2, new DateTime(1797, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 21, new DateTime(1825, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2, new DateTime(1823, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 22, new DateTime(1828, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2, new DateTime(1821, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 23, new DateTime(1829, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4, new DateTime(1829, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 24, new DateTime(1831, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 8, new DateTime(1829, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 25, new DateTime(1800, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, new DateTime(1799, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 26, new DateTime(1812, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4, new DateTime(1801, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 27, new DateTime(1819, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, new DateTime(1816, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 28, new DateTime(1828, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, new DateTime(1825, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 29, new DateTime(1821, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 3, new DateTime(1816, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 30, new DateTime(1827, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4, new DateTime(1825, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 31, new DateTime(1836, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 2, new DateTime(1827, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 32, new DateTime(1839, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 3, new DateTime(1825, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 33, new DateTime(1841, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 4, new DateTime(1839, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 34, new DateTime(1848, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 1, new DateTime(1845, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 35, new DateTime(1835, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 3, new DateTime(1833, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 36, new DateTime(1843, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 3, new DateTime(1837, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 37, new DateTime(1837, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, new DateTime(1833, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 38, new DateTime(1842, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 2, new DateTime(1837, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 39, new DateTime(1831, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3, new DateTime(1821, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 40, new DateTime(1845, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 2, new DateTime(1834, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 41, new DateTime(1849, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 8, new DateTime(1845, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 42, new DateTime(1849, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 3, new DateTime(1847, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 43, new DateTime(1853, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 3, new DateTime(1843, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 44, new DateTime(1857, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 4, new DateTime(1853, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 45, new DateTime(1862, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, new DateTime(1857, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 46, new DateTime(1875, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, new DateTime(1875, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 47, new DateTime(1869, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 1, new DateTime(1864, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 48, new DateTime(1867, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 3, new DateTime(1865, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 49, new DateTime(1872, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 4, new DateTime(1868, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 50, new DateTime(1877, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 4, new DateTime(1876, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 51, new DateTime(1880, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 3, new DateTime(1863, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 52, new DateTime(1881, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 9, new DateTime(1862, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 53, new DateTime(1882, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 5, new DateTime(1882, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 54, new DateTime(1885, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 4, new DateTime(1883, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 55, new DateTime(1897, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 2, new DateTime(1881, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 56, new DateTime(1884, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 3, new DateTime(1877, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 57, new DateTime(1891, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 3, new DateTime(1885, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 58, new DateTime(1896, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 4, new DateTime(1892, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 59, new DateTime(1900, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 4, new DateTime(1899, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 60, new DateTime(1908, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 8, new DateTime(1904, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 61, new DateTime(1930, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 6, new DateTime(1921, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 62, new DateTime(1913, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4, new DateTime(1911, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 63, new DateTime(1921, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 2, new DateTime(1915, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 64, new DateTime(1921, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 4, new DateTime(1919, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 65, new DateTime(1928, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 8, new DateTime(1921, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 67, new DateTime(1932, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 4, new DateTime(1929, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 68, new DateTime(1945, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 2, new DateTime(1935, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 69, new DateTime(1952, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1, new DateTime(1951, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 70, new DateTime(1953, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 3, new DateTime(1947, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 71, new DateTime(1960, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 2, new DateTime(1953, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 72, new DateTime(1949, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 3, new DateTime(1937, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 73, new DateTime(1961, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 2, new DateTime(1949, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 74, new DateTime(1950, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 3, new DateTime(1947, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 75, new DateTime(1953, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 2, new DateTime(1950, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 76, new DateTime(1973, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 3, new DateTime(1949, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 77, new DateTime(1975, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, new DateTime(1971, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 78, new DateTime(1975, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 4, new DateTime(1967, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 79, new DateTime(1971, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 3, new DateTime(1967, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 80, new DateTime(1981, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 4, new DateTime(1979, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 81, new DateTime(1992, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 4, new DateTime(1983, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 82, new DateTime(2000, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 4, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 83, new DateTime(2008, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 2, new DateTime(2005, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 84, new DateTime(2017, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 9, new DateTime(1971, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 85, new DateTime(2009, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 2, new DateTime(1973, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 86, new DateTime(1797, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 2, new DateTime(1791, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 87, new DateTime(1776, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 7, new DateTime(1775, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 88, new DateTime(1795, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 4, new DateTime(1777, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 89, new DateTime(1804, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 4, new DateTime(1801, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 90, new DateTime(1793, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 3, new DateTime(1789, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 91, new DateTime(1812, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 4, new DateTime(1810, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 92, new DateTime(1817, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 4, new DateTime(1807, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 93, new DateTime(1817, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 3, new DateTime(1811, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 94, new DateTime(1825, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 8, new DateTime(1817, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 95, new DateTime(1845, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 8, new DateTime(1844, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 96, new DateTime(1843, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 2, new DateTime(1832, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 97, new DateTime(1850, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 2, new DateTime(1845, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 98, new DateTime(1819, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 3, new DateTime(1807, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 99, new DateTime(1837, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 3, new DateTime(1829, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 100, new DateTime(1829, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 2, new DateTime(1819, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 101, new DateTime(1829, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 5, new DateTime(1829, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 102, new DateTime(1833, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 2, new DateTime(1831, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 103, new DateTime(1816, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 3, new DateTime(1811, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 104, new DateTime(1844, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 2, new DateTime(1819, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 105, new DateTime(1852, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 2, new DateTime(1848, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 106, new DateTime(1855, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 3, new DateTime(1851, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 107, new DateTime(1861, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 2, new DateTime(1861, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 108, new DateTime(1847, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 3, new DateTime(1843, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 109, new DateTime(1857, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 4, new DateTime(1857, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 110, new DateTime(1857, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 2, new DateTime(1847, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 111, new DateTime(1861, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 2, new DateTime(1857, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 112, new DateTime(1881, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 2, new DateTime(1869, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 113, new DateTime(1869, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 3, new DateTime(1855, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 114, new DateTime(1873, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 2, new DateTime(1855, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 115, new DateTime(1863, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 3, new DateTime(1861, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 116, new DateTime(1877, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 3, new DateTime(1869, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 117, new DateTime(1855, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 3, new DateTime(1851, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 118, new DateTime(1869, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 2, new DateTime(1863, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 119, new DateTime(1877, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 4, new DateTime(1873, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 120, new DateTime(1881, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 3, new DateTime(1879, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 121, new DateTime(1896, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 4, new DateTime(1895, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 122, new DateTime(1877, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 3, new DateTime(1875, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 123, new DateTime(1881, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 3, new DateTime(1879, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 124, new DateTime(1883, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 2, new DateTime(1881, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 125, new DateTime(1905, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 2, new DateTime(1897, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 126, new DateTime(1885, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 5, new DateTime(1884, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 127, new DateTime(1909, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 3, new DateTime(1893, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 128, new DateTime(1891, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 3, new DateTime(1887, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 129, new DateTime(1913, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 4, new DateTime(1909, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 130, new DateTime(1925, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 9, new DateTime(1898, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 131, new DateTime(1907, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 3, new DateTime(1893, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 132, new DateTime(1913, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 2, new DateTime(1907, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 133, new DateTime(1929, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 2, new DateTime(1915, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 134, new DateTime(1933, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 3, new DateTime(1903, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 135, new DateTime(1940, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 8, new DateTime(1933, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 136, new DateTime(1946, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 8, new DateTime(1945, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 137, new DateTime(1927, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 3, new DateTime(1913, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 138, new DateTime(1949, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 2, new DateTime(1927, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 139, new DateTime(1956, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 2, new DateTime(1955, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 140, new DateTime(1948, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 5, new DateTime(1945, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 141, new DateTime(1964, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 2, new DateTime(1949, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 142, new DateTime(1978, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 2, new DateTime(1971, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 143, new DateTime(1969, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 4, new DateTime(1967, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 144, new DateTime(1973, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 4, new DateTime(1959, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 145, new DateTime(1976, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 2, new DateTime(1954, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 146, new DateTime(1981, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 3, new DateTime(1977, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 147, new DateTime(1989, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 2, new DateTime(1981, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 148, new DateTime(1985, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 3, new DateTime(1977, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 149, new DateTime(1993, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 2, new DateTime(1985, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 150, new DateTime(1989, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 3, new DateTime(1979, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 151, new DateTime(1993, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 8, new DateTime(1989, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 152, new DateTime(2013, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 3, new DateTime(2001, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 153, new DateTime(2017, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 4, new DateTime(2013, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 154, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 2, new DateTime(2017, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "BirthPlaces",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "DateOfBirth", "DateOfDeath", "FirstName", "LastName", "MiddleName" },
                values: new object[] { 86, new DateTime(1913, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerald", "Ford", null });

            migrationBuilder.UpdateData(
                table: "PreviousExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDay", "PublicOfficeId", "StartDay" },
                values: new object[] { new DateTime(1783, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1775, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
