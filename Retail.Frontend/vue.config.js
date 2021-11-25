const CopyWebpackPlugin = require('copy-webpack-plugin')

module.exports = {
    configureWebpack: {
      plugins: [
        new CopyWebpackPlugin({
            patterns: [
                { from: 'node_modules/oidc-client/dist/oidc-client.min.js', to: 'js' }
            ]
        })
      ]
    }
  }