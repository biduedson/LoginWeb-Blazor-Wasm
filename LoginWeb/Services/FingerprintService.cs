using Microsoft.JSInterop;

namespace LoginWeb.Services
{
    public class FingerprintService
    {
        private readonly IJSRuntime _js;

        public FingerprintService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<string> GetFingerprintAsync()
        {
            return await _js.InvokeAsync<string>("getFingerprint");
        }
    }
}
