import { View, Text } from 'react-native'
import { Stack } from 'expo-router'
import { StatusBar } from 'expo-status-bar'
import React from 'react'

const ProductLayout = () => {
  return (
    <>
      <Stack>
        <Stack.Screen 
          name='product'
          options={{ headerShown: false }}
        />
      </Stack>
      <StatusBar backgroundColor='#861BE0' style='light'/>
    </>
  )
}

export default ProductLayout