using System.Collections.Generic;
using System;

namespace Server.Features.ProjectAnalysisDefinitionFeature
{
    public class ProjectAnalysisDefinition
    {

        public static IEnumerable<AnalysisPrinciples> GetPrinciples()
        {
            return new List<AnalysisPrinciples>()
            {
                new AnalysisPrinciples
                {
                    Title = "Vernetzung anstreben",
                    ShortDescription = "Einbezug verschiedener Werthaltungen und Erfahrungen",
                    Aspects = new List<string>
                    {
                        "Verschiedene Interessenvertretungen arbeiten zusammen",
                        "Erfahrungen aus ähnlichen Projekten sind berücksichtigt",
                        "Interdisziplinäres arbeiten wird gepflegt"
                    }
                },
                new AnalysisPrinciples
                {
                    Title = "Kommunikation fördern",
                    ShortDescription = "Transparente Information Schaffung von Plattformen und/oder Medien für den Informationsaustausch",
                    Aspects = new List<string>
                    {
                        "Anwenden des Kommunikationsreglemetes",
                        "Einsatz moderner Dialogformen und Technologien",
                        "Wo möglich werden die Informationen öffentlich zugänglich gemacht.",
                        "Alle vom Projekt betroffenen Personen werden regelmässig informiert."
                    }
                },             
                new AnalysisPrinciples
                {
                    Title = "Partizipation leben",
                    ShortDescription = "Konsensorientierte Entscheidungsfindung Förderung kaum organisierter Interessen",
                    Aspects = new List<string>
                    {
                        "Alle wichtigen Akteure sind in der Projektgruppe vertreten.",
                        "Die vom Projekt betroffenen Personen werden rechtzeitig einbezogen.",
                        "Die Interessen spezieller Gruppen sind evaluiert und berücksichtigt",
                        "Die Kompetenzen sind geregelt und werden klar kommuniziert."
                    }
                },
                new AnalysisPrinciples
                {
                    Title = "Regionale Ausrichtung verfolgen",
                    ShortDescription = "Nutzen von Synergien",
                    Aspects = new List<string>
                    {
                        "Synergien mit umliegenden Gemeinden und Regionen werden genutzt.",
                        "Regionale Zusammenhänge sind erkannt"
                    }
                },
                new AnalysisPrinciples
                {
                    Title = "Zukunftsgerichtete Finanzierung sichern",
                    ShortDescription = "Projekt- und Massnahmenfinanzierung",
                    Aspects = new List<string>
                    {
                        "Anwendung vom Verursacherprinzip",
                        "Keine Wettbewerbsverzerrung",
                        "Sozialverträgliche Finanzierung"
                    }
                },
                new AnalysisPrinciples
                {
                    Title = "Monitoring durchführen",
                    ShortDescription = "Anwenden des ergänzten Projektmanagement",
                    Aspects = new List<string>
                    {
                        "Messbare Ziele sind gesetzt",
                        "Zielüberprüfung nach Projektabschluss"
                    }
                }
            };
        }

        public static IEnumerable<Question> GetAllQuestions()
        {
            var rnd = new Random();
            return new List<Question>()
            {
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Wirtschaft,
                    Keyword = "Einkommen",
                    Text = "Erhöht das Einkommen privater Haushalte",
                    Date = DateTime.Now.AddHours(-rnd.Next(200))
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Wirtschaft,
                    Keyword = "Lebenskosten",
                    Text = "Senkt die durchschnittlichen privaten Lebenskosten",
                    Date = DateTime.Now.AddHours(-rnd.Next(200))
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Wirtschaft,
                    Keyword = "Öffentlicher Haushalt",
                    Text = "Verbessert die öffentlichen Finanzen",
                    Date = DateTime.Now.AddHours(-rnd.Next(200))
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Wirtschaft,
                    Keyword = "Infrastruktur",
                    Text = "Ausbau und Werterhaltung der öffentlichen Infrastruktur",
                    Date = DateTime.Now.AddHours(-rnd.Next(200))
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Wirtschaft,
                    Keyword = "Wirtschaftsstruktur",
                    Text = "Verbessert die Branchenstruktur Fördert Know-how und Innovationskraft Fördert lokale Wertschöpfung Verbessert Arbeitsplatzqualität",
                                        Date = DateTime.Now.AddHours(-rnd.Next(200))
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Wirtschaft,
                    Keyword = "Markt-Mechanismen",
                    Text = "Begünstigt die freie Preisbildung und die Kostenwahrheit",
                                        Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Umwelt,
                    Keyword = "Klima",
                    Text = "Vermindert den Ausstoss klimarelevanter Gase",
                                        Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Umwelt,
                    Keyword = "Energie Verbrauch",
                    Text = "Vermindert den Energieverbrauch",
                                        Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Umwelt,
                    Keyword = "Ressourcen",
                    Text = "Vermindert den Verbrauch von Rohstoffen und Materialien",
                                        Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Umwelt,
                    Keyword = "Schadstoffe und Risiko",
                    Text = "Vermeidet schädliche Einwirkungen auf die Umwelt und den Wasserhaushalt Reduziert irreversible Umweltschäden",
                                        Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Umwelt,
                    Keyword = "Boden",
                    Text = "Minimiert den Flächenverbrauch Erhält die Bodenfruchtbarkeit",
                                        Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Umwelt,
                    Keyword = "Naturräume",
                    Text = "Fördert naturnahe Landschaften Fördert die Artenvielfalt",
                                        Date = DateTime.Now.AddHours(-rnd.Next(200))

                },

                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Gesellschaft,
                    Keyword = "Wohnqualität",
                    Text = "Fördert Wohnqualität, Erreichbarkeit und funktionale Durchmischung der Siedlungen",                     Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Gesellschaft,
                    Keyword = "Gesundheit",
                    Text = "Fördert körperliche und psychische Gesundheit, senkt Gesundheitsrisiken",                     Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Gesellschaft,
                    Keyword = "Sicherheit",
                    Text = "Fördert persönliche Freiheit und Sicherheitsgefühl",                     Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Gesellschaft,
                    Keyword = "Integration und Partizpation",
                    Text = "Fördert eine ausgewogene Bevölkerungsstruktur und die demokratische Mitbestimmung Fördert die Integration (Arbeitsmarkt/ Gesellschaft) und das Vertrauen (informell/instituionell)"
                ,                    Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Gesellschaft,
                    Keyword = "Bildung und Kultur",
                    Text = "Fördert Bildungschancen und Bildungsangebote Fördert die kulturelle Vielfalt",
                                        Date = DateTime.Now.AddHours(-rnd.Next(200))

                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Domain = QuestionDomain.Gesellschaft,
                    Keyword = "Chancengleichenheit und Solidarität",
                    Text = "Fördert die Chancengleichheit aller Menschen und die Vereinbarkeit von Familie, Beruf sowie ausserberufliches Engagement Fördert die Solidarität (Generationen- und Bevölkerunsgruppen übergreifend, regional und global)"
                ,                    Date = DateTime.Now.AddHours(-rnd.Next(200))
                }
            };
        }
    }
}
