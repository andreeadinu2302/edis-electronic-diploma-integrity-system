using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UnibucWebAgentFrontend.Models;

namespace UnibucWebAgentFrontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "http://63.33.67.136:8080/status/config");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("User-Agent", "EDIS Frontend");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var connections = await JsonSerializer.DeserializeAsync<ServerStatusResponse>(responseStream);
                return View(connections);
            }
            else
            {
                return View(new ServerStatusResponse());
            }
        }

        public async Task<IActionResult> ConnectionsAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "http://63.33.67.136:8080/connections");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("User-Agent", "EDIS Frontend");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var connections = await JsonSerializer.DeserializeAsync<ConnectionsResponse>(responseStream);
                return View(connections.results);
            }
            else
            {
                return View(new List<Connection>());
            }
        }

        public async Task<IActionResult> AdeverintaStudentAsync()
        {
            //Get all the connections and prepare them for a dropdown
            var request = new HttpRequestMessage(HttpMethod.Get, "http://63.33.67.136:8080/connections");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("User-Agent", "EDIS Frontend");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var connections = await JsonSerializer.DeserializeAsync<ConnectionsResponse>(responseStream);
                return View(connections.results);
            }
            else
            {
                return View(new List<Connection>());
            }
        }

        public async Task<IActionResult> DiplomaStudentAsync()
        {
            //Get all the connections and prepare them for a dropdown
            var request = new HttpRequestMessage(HttpMethod.Get, "http://63.33.67.136:8080/connections");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("User-Agent", "EDIS Frontend");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var connections = await JsonSerializer.DeserializeAsync<ConnectionsResponse>(responseStream);
                return View(connections.results);
            }
            else
            {
                return View(new List<Connection>());
            }
        }

        [HttpPost]
        public async Task<IActionResult> IssueDiplomaAsync(string forma_invatamant, string facultatea, string program_studii, string media, string connection_id)
        {
            //Create the credential
            var credential_section = new List<CredentialAttributes>();
            credential_section.Add(new CredentialAttributes
            {
                name = "Forma de invatamant",
                value = forma_invatamant
            });
            credential_section.Add(new CredentialAttributes
            {
                name = "Universitatea",
                value = "Universitatea din Bucuresti"
            });
            credential_section.Add(new CredentialAttributes
            {
                name = "Facultatea",
                value = facultatea
            });
            credential_section.Add(new CredentialAttributes
            {
                name = "Programul de studii",
                value = program_studii
            });
            credential_section.Add(new CredentialAttributes
            {
                name = "Media examenului de finalizare",
                value = media
            });

            //Prepare the JSON for adeverinta student
            var obj = new IssueCredentialModel
            {
                auto_remove = true,
                comment = "Diploma studii Unibuc",
                connection_id = connection_id,
                credential_proposal = new CredentialProposal
                {
                    type = "issue-credential/2.0/credential-preview",
                    attributes = credential_section
                },
                filter = new Filter
                {
                    indy = new Indy
                    {
                        cred_def_id = _configuration["DiplomaStudii:CredentialDefinitionId"],
                        issuer_did = _configuration["CloudWallet:DID"],
                        schema_id = _configuration["DiplomaStudii:SchemaId"],
                        schema_issuer_did = _configuration["CloudWallet:DID"],
                        schema_name = _configuration["DiplomaStudii:SchemaName"],
                        schema_version = _configuration["DiplomaStudii:SchemaVersion"]
                    }
                },
                trace = false
            };

            var request = new HttpRequestMessage(HttpMethod.Post, "http://63.33.67.136:8080/issue-credential/send");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("ContentType", "application/json");
            request.Content = new StringContent(JsonSerializer.Serialize(obj), Encoding.UTF8, "application/json");
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Connections", "Home");
            }
            else
            {
                ViewBag.test = JsonSerializer.Serialize(obj);
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> IssueAdeverintaAsync(string an_studiu, string program_studii, string faculty, string connection_id)
        {
            //Create the credential
            var credential_section = new List<CredentialAttributes>();
            credential_section.Add(new CredentialAttributes
            {
                name = "Facultatea",
                value = faculty
            });
            credential_section.Add(new CredentialAttributes
            {
                name = "Programul de studiu",
                value = program_studii
            });
            credential_section.Add(new CredentialAttributes
            {
                name = "Anul de studiu",
                value = an_studiu
            });
            credential_section.Add(new CredentialAttributes
            {
                name = "Universitatea",
                value = "Universitatea din Bucuresti"
            });

            //Prepare the JSON for adeverinta student
            var obj = new IssueCredentialModel
            {
                auto_remove = true,
                comment = "Adeverinta student Unibuc",
                connection_id = connection_id,
                credential_proposal = new CredentialProposal
                {
                    type = "issue-credential/2.0/credential-preview",
                    attributes = credential_section
                },
                filter = new Filter
                {
                    indy = new Indy
                    {
                        cred_def_id = _configuration["AdeverintaStudent:CredentialDefinitionId"],
                        issuer_did = _configuration["CloudWallet:DID"],
                        schema_id = _configuration["AdeverintaStudent:SchemaId"],
                        schema_issuer_did = _configuration["CloudWallet:DID"],
                        schema_name = _configuration["AdeverintaStudent:SchemaName"],
                        schema_version = _configuration["AdeverintaStudent:SchemaVersion"]
                    }
                },
                trace = false
            };

            var request = new HttpRequestMessage(HttpMethod.Post, "http://63.33.67.136:8080/issue-credential/send");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("ContentType", "application/json");
            request.Content = new StringContent(JsonSerializer.Serialize(obj), Encoding.UTF8, "application/json");
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Connections", "Home");
            }
            else
            {
                ViewBag.test = JsonSerializer.Serialize(obj);
                return View();
            }
        }

        public async Task<IActionResult> CreateConnectionAsync(string alias)
        {
            var request = new HttpRequestMessage(HttpMethod.Post,
                "http://63.33.67.136:8080/connections/create-invitation?alias=" + alias);
            request.Headers.Add("Accept", "application/json");
            request.Content = new ByteArrayContent(Encoding.ASCII.GetBytes("{}"));
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var invite = await JsonSerializer.DeserializeAsync<CreateConnectionResponse>(responseStream);
                QRCodeGenerator _qrCode = new QRCodeGenerator();
                QRCodeData _qrCodeData = _qrCode.CreateQrCode(invite.invitation_url, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(_qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                return View(BitmapToBytesCode(qrCodeImage));
            }
            else
            {
                return View(new MemoryStream().ToArray());
            }
        }

        public IActionResult SendMessagePage(string id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessageAsync(string id, string content)
        {
            var request = new HttpRequestMessage(HttpMethod.Post,
               "http://63.33.67.136:8080/connections/" + id + "/send-message");
            request.Headers.Add("Accept", "application/json");
            request.Content = new ByteArrayContent(Encoding.ASCII.GetBytes($"{{ \"content\": \"{content}\" }}"));
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Connections", "Home");
            }
            else
            {
                return RedirectToAction("Connections", "Home");
            }
        }

        public async Task<IActionResult> DeleteConnectionAsync(string id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete,
                "http://63.33.67.136:8080/connections/" + id);
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Connections", "Home");
            }
            else
            {
                return RedirectToAction("Connections", "Home");
            }
        }

        public IActionResult Issue()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [NonAction]
        private static Byte[] BitmapToBytesCode(Bitmap image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}
