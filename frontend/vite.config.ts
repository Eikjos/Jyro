import react from '@vitejs/plugin-react-swc';
import { defineConfig, loadEnv } from 'vite';
import tsconfigPaths from 'vite-tsconfig-paths';

// https://vitejs.dev/config/
export default ({ mode }) => {
  const env = loadEnv(mode, process.cwd(), '');
  return defineConfig({
    define: {
      __APP_ENV__: JSON.stringify(env.APP_ENV),
    },
    server: {
      host: true,
      strictPort: true,
      port: 3000,
    },
    plugins: [react(), tsconfigPaths()],
  });
};
