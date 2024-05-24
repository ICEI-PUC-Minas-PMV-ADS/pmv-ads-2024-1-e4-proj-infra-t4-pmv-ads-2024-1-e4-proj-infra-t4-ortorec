import { View, Text } from 'react-native'
import { Stack } from 'expo-router'
import { StatusBar } from 'expo-status-bar'
import React from 'react'

const AuthLayout = () => {
  return (
    <>
      <Stack>
        <Stack.Screen 
          name='login'
          options={{ headerShown: false }}
        />
        <Stack.Screen 
          name='registrar'
          options={{ headerShown: false }}
        />
      </Stack>

      <StatusBar backgroundColor='#A168ED' style='light'/>
    </>
  )
}

export default AuthLayout