import { View, Text, StyleSheet, Pressable } from 'react-native'
import { router } from "expo-router";
import { CustomButton } from '../../components/CustomButton'
import React from 'react'

{/* Coloquei apenas um botão para que possam mudar para a página que estão desenvolvendo */}
const Login = () => {
  return (
    
    <View style={styles.container}>
      <Pressable
          style={({ pressed }) => [
            styles.button,
            pressed && { backgroundColor: '#A168ED'},
          ]}
          onPress={() => router.push('/registrar')}
          >
            <Text style={{ color: 'white', fontWeight: 'bold'}}> Ir para Tela de Registro</Text>
      </Pressable>
    </View>
  )
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  button: {
    alignItems: 'center',
    justifyContent: 'center',
    paddingVertical: 26,
    paddingHorizontal: 48,
    borderRadius: 10,
    elevation: 3,
    backgroundColor: '#fb00ff',
    borderColor: '#fb00ff',
    padding: 20,
    margin: 10,
  },
})
export default Login