const devUrl = '/api'
const prodUrl = process.env
export const baseUrl = process.env.NODE_ENV === 'production' ? prodUrl : devUrl
