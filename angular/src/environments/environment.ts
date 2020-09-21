import { Config } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Direct',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44333',
    redirectUri: baseUrl,
    clientId: 'Direct_App',
    responseType: 'code',
    scope: 'offline_access Direct',
  },
  apis: {
    default: {
      url: 'https://localhost:44352',
      rootNamespace: 'RadixS.Farmers.Direct',
    },
  },
} as Config.Environment;
