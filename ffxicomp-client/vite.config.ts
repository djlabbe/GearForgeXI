import { defineConfig } from "vite";
import tailwindcss from "@tailwindcss/vite";
import react from "@vitejs/plugin-react";

export default defineConfig({
  plugins: [react(), tailwindcss()],
  server: {
    proxy: {
      "/api": {
        target: "https://localhost:7152",
        changeOrigin: true,
        secure: false, // disables SSL cert validation for dev
      },
    },
  },
});
