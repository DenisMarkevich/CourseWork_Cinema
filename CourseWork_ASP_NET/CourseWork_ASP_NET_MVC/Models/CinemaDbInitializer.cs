﻿using System.Collections.Generic;
using System.Data.Entity;

namespace CourseWork_ASP_NET_MVC.Models
{
    internal class CinemaDbInitializer : DropCreateDatabaseIfModelChanges<CinemaContext>
    {
        protected override void Seed(CinemaContext ctx)
        {
            List<Genre> genres = new List<Genre>
            {
                new Genre { Name = "Action" },
                new Genre { Name = "Adventure" },
                new Genre { Name = "Animated" },
                new Genre { Name = "Biography" },
                new Genre { Name = "Comedy" },
                new Genre { Name = "Crime" },
                new Genre { Name = "Documentary" },
                new Genre { Name = "Drana" },
                new Genre { Name = "Fantasy" },
                new Genre { Name = "Historical" },
                new Genre { Name = "Horror" },
                new Genre { Name = "Kids" },
                new Genre { Name = "Musical" },
                new Genre { Name = "Romance" },
                new Genre { Name = "Science Fiction" },
                new Genre { Name = "Thriller" },
                new Genre { Name = "War" },
                new Genre { Name = "Westerns" },
            };
            ctx.Genres.AddRange(genres);

            List<ShowStatus> statuses = new List<ShowStatus>
            {
                new ShowStatus { Name = "Showing" },
                new ShowStatus { Name = "Closed" },
                new ShowStatus { Name = "Coming" },
            };
            ctx.ShowStatuses.AddRange(statuses);

            List<Country> countries = new List<Country>
            {
                new Country { Name = "China" },
                new Country { Name = "India" },
                new Country { Name = "United States" },
                new Country { Name = "Indonesia" },
                new Country { Name = "Brazil" },
                new Country { Name = "Pakistan" },
                new Country { Name = "Nigeria" },
                new Country { Name = "Bangladesh" },
                new Country { Name = "Russia" },
                new Country { Name = "Japan" },
                new Country { Name = "Mexico" },
                new Country { Name = "Philippines" },
                new Country { Name = "Vietnam" },
                new Country { Name = "Ethiopia" },
                new Country { Name = "Egypt" },
                new Country { Name = "Germany" },
                new Country { Name = "Iran" },
                new Country { Name = "Turkey" },
                new Country { Name = "Democratic Republic of the Congo" },
                new Country { Name = "Thailand" },
                new Country { Name = "France" },
                new Country { Name = "United Kingdom" },
                new Country { Name = "Italy" },
                new Country { Name = "Burma" },
                new Country { Name = "South Africa" },
                new Country { Name = "South Korea" },
                new Country { Name = "Colombia" },
                new Country { Name = "Spain" },
                new Country { Name = "Ukraine" },
                new Country { Name = "Tanzania" },
                new Country { Name = "Kenya" },
                new Country { Name = "Argentina" },
                new Country { Name = "Algeria" },
                new Country { Name = "Poland" },
                new Country { Name = "Sudan" },
                new Country { Name = "Uganda" },
                new Country { Name = "Canada" },
                new Country { Name = "Iraq" },
                new Country { Name = "Morocco" },
                new Country { Name = "Peru" },
                new Country { Name = "Uzbekistan" },
                new Country { Name = "Saudi Arabia" },
                new Country { Name = "Malaysia" },
                new Country { Name = "Venezuela" },
                new Country { Name = "Nepal" },
                new Country { Name = "Afghanistan" },
                new Country { Name = "Yemen" },
                new Country { Name = "North Korea" },
                new Country { Name = "Ghana" },
                new Country { Name = "Mozambique" },
                new Country { Name = "Taiwan" },
                new Country { Name = "Australia" },
                new Country { Name = "Ivory Coast" },
                new Country { Name = "Syria" },
                new Country { Name = "Madagascar" },
                new Country { Name = "Angola" },
                new Country { Name = "Cameroon" },
                new Country { Name = "Sri Lanka" },
                new Country { Name = "Romania" },
                new Country { Name = "Burkina Faso" },
                new Country { Name = "Niger" },
                new Country { Name = "Kazakhstan" },
                new Country { Name = "Netherlands" },
                new Country { Name = "Chile" },
                new Country { Name = "Malawi" },
                new Country { Name = "Ecuador" },
                new Country { Name = "Guatemala" },
                new Country { Name = "Mali" },
                new Country { Name = "Cambodia" },
                new Country { Name = "Senegal" },
                new Country { Name = "Zambia" },
                new Country { Name = "Zimbabwe" },
                new Country { Name = "Chad" },
                new Country { Name = "South Sudan" },
                new Country { Name = "Belgium" },
                new Country { Name = "Cuba" },
                new Country { Name = "Tunisia" },
                new Country { Name = "Guinea" },
                new Country { Name = "Greece" },
                new Country { Name = "Portugal" },
                new Country { Name = "Rwanda" },
                new Country { Name = "Czech Republic" },
                new Country { Name = "Somalia" },
                new Country { Name = "Haiti" },
                new Country { Name = "Benin" },
                new Country { Name = "Burundi" },
                new Country { Name = "Bolivia" },
                new Country { Name = "Hungary" },
                new Country { Name = "Sweden" },
                new Country { Name = "Belarus" },
                new Country { Name = "Dominican Republic" },
                new Country { Name = "Azerbaijan" },
                new Country { Name = "Honduras" },
                new Country { Name = "Austria" },
                new Country { Name = "United Arab Emirates" },
                new Country { Name = "Israel" },
                new Country { Name = "Switzerland" },
                new Country { Name = "Tajikistan" },
                new Country { Name = "Bulgaria" },
                new Country { Name = "Hong Kong(China)" },
                new Country { Name = "Serbia" },
                new Country { Name = "Papua New Guinea" },
                new Country { Name = "Paraguay" },
                new Country { Name = "Laos" },
                new Country { Name = "Jordan" },
                new Country { Name = "El Salvador" },
                new Country { Name = "Eritrea" },
                new Country { Name = "Libya" },
                new Country { Name = "Togo" },
                new Country { Name = "Sierra Leone" },
                new Country { Name = "Nicaragua" },
                new Country { Name = "Kyrgyzstan" },
                new Country { Name = "Denmark" },
                new Country { Name = "Finland" },
                new Country { Name = "Slovakia" },
                new Country { Name = "Singapore" },
                new Country { Name = "Turkmenistan" },
                new Country { Name = "Norway" },
                new Country { Name = "Lebanon" },
                new Country { Name = "Costa Rica" },
                new Country { Name = "Central African Republic" },
                new Country { Name = "Ireland" },
                new Country { Name = "Georgia" },
                new Country { Name = "New Zealand" },
                new Country { Name = "Republic of the Congo" },
                new Country { Name = "Palestine" },
                new Country { Name = "Liberia" },
                new Country { Name = "Croatia" },
                new Country { Name = "Oman" },
                new Country { Name = "Bosnia and Herzegovina" },
                new Country { Name = "Puerto Rico" },
                new Country { Name = "Kuwait" },
                new Country { Name = "Moldov" },
                new Country { Name = "Mauritania" },
                new Country { Name = "Panama" },
                new Country { Name = "Uruguay" },
                new Country { Name = "Armenia" },
                new Country { Name = "Lithuania" },
                new Country { Name = "Albania" },
                new Country { Name = "Mongolia" },
                new Country { Name = "Jamaica" },
                new Country { Name = "Namibia" },
                new Country { Name = "Lesotho" },
                new Country { Name = "Qatar" },
                new Country { Name = "Macedonia" },
                new Country { Name = "Slovenia" },
                new Country { Name = "Botswana" },
                new Country { Name = "Latvia" },
                new Country { Name = "Gambia" },
                new Country { Name = "Kosovo" },
                new Country { Name = "Guinea-Bissau" },
                new Country { Name = "Gabon" },
                new Country { Name = "Equatorial Guinea" },
                new Country { Name = "Trinidad and Tobago" },
                new Country { Name = "Estonia" },
                new Country { Name = "Mauritius" },
                new Country { Name = "Swaziland" },
                new Country { Name = "Bahrain" },
                new Country { Name = "Timor-Leste" },
                new Country { Name = "Djibouti" },
                new Country { Name = "Cyprus" },
                new Country { Name = "Fiji" },
                new Country { Name = "Reunion(France)" },
                new Country { Name = "Guyana" },
                new Country { Name = "Comoros" },
                new Country { Name = "Bhutan" },
                new Country { Name = "Montenegro" },
                new Country { Name = "Macau(China)" },
                new Country { Name = "Solomon Islands" },
                new Country { Name = "Western Sahara" },
                new Country { Name = "Luxembourg" },
                new Country { Name = "Suriname" },
                new Country { Name = "Cape Verde" },
                new Country { Name = "Malta" },
                new Country { Name = "Guadeloupe(France)" },
                new Country { Name = "Martinique(France)" },
                new Country { Name = "Brunei" },
                new Country { Name = "Bahamas" },
                new Country { Name = "Iceland" },
                new Country { Name = "Maldives" },
                new Country { Name = "Belize" },
                new Country { Name = "Barbados" },
                new Country { Name = "French Polynesia(France)" },
                new Country { Name = "Vanuatu" },
                new Country { Name = "New Caledonia(France)" },
                new Country { Name = "French Guiana(France)" },
                new Country { Name = "Mayotte(France)" },
                new Country { Name = "Samoa" },
                new Country { Name = "Sao Tom and Principe" },
                new Country { Name = "Saint Lucia" },
                new Country { Name = "Guam(USA)" },
                new Country { Name = "Curacao(Netherlands)" },
                new Country { Name = "Saint Vincent and the Grenadines" },
                new Country { Name = "Kiribati" },
                new Country { Name = "United States Virgin Islands(USA)" },
                new Country { Name = "Grenada" },
                new Country { Name = "Tonga" },
                new Country { Name = "Aruba(Netherlands)" },
                new Country { Name = "Federated States of Micronesia" },
                new Country { Name = "Jersey(UK)" },
                new Country { Name = "Seychelles" },
                new Country { Name = "Antigua and Barbuda" },
                new Country { Name = "Isle of Man(UK)" },
                new Country { Name = "Andorra" },
                new Country { Name = "Dominica" },
                new Country { Name = "Bermuda(UK)" },
                new Country { Name = "Guernsey(UK)" },
                new Country { Name = "Greenland(Denmark)" },
                new Country { Name = "Marshall Islands" },
                new Country { Name = "American Samoa(USA)" },
                new Country { Name = "Cayman Islands(UK)" },
                new Country { Name = "Saint Kitts and Nevis" },
                new Country { Name = "Northern Mariana Islands(USA)" },
                new Country { Name = "Faroe Islands(Denmark)" },
                new Country { Name = "Sint Maarten(Netherlands)" },
                new Country { Name = "Saint Martin(France)" },
                new Country { Name = "Liechtenstein" },
                new Country { Name = "Monaco" },
                new Country { Name = "San Marino" },
                new Country { Name = "Turks and Caicos Islands(UK)" },
                new Country { Name = "Gibraltar(UK)" },
                new Country { Name = "British Virgin Islands(UK)" },
                new Country { Name = "Aland Islands(Finland)" },
                new Country { Name = "Caribbean Netherlands(Netherlands)" },
                new Country { Name = "Palau" },
                new Country { Name = "Cook Islands(NZ)" },
                new Country { Name = "Anguilla(UK)" },
                new Country { Name = "Wallis and Futuna(France)" },
                new Country { Name = "Tuvalu" },
                new Country { Name = "Nauru" },
                new Country { Name = "Saint Barthelemy(France)" },
                new Country { Name = "Saint Pierre and Miquelon(France)" },
                new Country { Name = "Montserrat(UK)" },
                new Country { Name = "Saint Helena, Ascension and Tristan da Cunha(UK)" },
                new Country { Name = "Svalbard and Jan Mayen(Norway)" },
                new Country { Name = "Falkland Islands(UK)" },
                new Country { Name = "Norfolk Island(Australia)" },
                new Country { Name = "Christmas Island(Australia)" },
                new Country { Name = "Niue(NZ)" },
                new Country { Name = "Tokelau(NZ)" },
                new Country { Name = "Vatican City" },
                new Country { Name = "Cocos(Keeling) Islands(Australia)" },
                new Country { Name = "Pitcairn Islands(UK)" }
            };
            ctx.Countries.AddRange(countries);

            ctx.SaveChanges();
            base.Seed(ctx);
        }
    }
}