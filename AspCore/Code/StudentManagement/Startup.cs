using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace StudentManagement
{
    public class Startup
    {

        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration){
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // �м��1
            if (env.IsDevelopment())
            {
                // ���ڿ�����Ա������ҳ��
                app.UseDeveloperExceptionPage();
            }
           

            // �м��2  �����������󣬶��ᱻapp.run����
            app.Run(async (context) =>
            {
                var configVal = _configuration["myKey"];
                // ��ȡhttp����ͷ����ӡֵ
                await context.Response.WriteAsync(configVal);
            });

        }
    }
}