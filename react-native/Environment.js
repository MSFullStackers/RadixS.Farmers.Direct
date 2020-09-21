const ENV = {
  dev: {
    apiUrl: 'http://localhost:44399',
    oAuthConfig: {
      issuer: 'http://localhost:44399',
      clientId: 'Direct_App',
      clientSecret: '1q2w3e*',
      scope: 'Direct',
    },
    localization: {
      defaultResourceName: 'Direct',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44399',
    oAuthConfig: {
      issuer: 'http://localhost:44399',
      clientId: 'Direct_App',
      clientSecret: '1q2w3e*',
      scope: 'Direct',
    },
    localization: {
      defaultResourceName: 'Direct',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
