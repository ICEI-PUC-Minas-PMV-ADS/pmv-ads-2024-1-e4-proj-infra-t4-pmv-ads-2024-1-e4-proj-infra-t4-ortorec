import { View, Text, Image } from 'react-native'
import { Tabs, Redirect } from 'expo-router'

import { icons } from '../../constants'

{/* Configuração do ícone de navegação */ }
const TabIcon = ({ icon, color, name, focused }) => {
  return (
    <View className="items-center justify-center gap-2">
      <Image 
        source={icon}
        resizeMode='contain'
        tintColor={color}
        className="w-6 h-6"
      />
      <Text className={`${focused ? 'font-psemibold' : 'font-pregular'} text-xs`} style={{ color: color }}>
        {name}
      </Text>
    </View>
  )
}

const TabsLayout = () => {
  return (
    <>
    { /* Estilização da barra de navegação */ }
      <Tabs 
        screenOptions={{
          tabBarShowLabel: false,
          tabBarActiveTintColor: '#D562E0',
          tabBarInactiveTintColor: '#9B9BA8',
          tabBarStyle: {
            backgroundColor: '#CDCDE0',
            borderTopWidth: 1,
            borderTopColor: '#C25ACC',
            height: 75,
          }
        }}
      >
        {/* Configuração dos links das telas, que correspondem a cada página criada em (tabs) */}
        <Tabs.Screen 
          name='home'
          options={{ 
            title: 'Home', 
            headerShown: false,
            tabBarIcon: ({ color, focused }) => (
              <TabIcon 
                icon={icons.home}
                color={color}
                name='Home'
                focused={focused}
              />
            )
          }}
        />
        <Tabs.Screen 
          name='servicos'
          options={{ 
            title: 'Servicos', 
            headerShown: false,
            tabBarIcon: ({ color, focused }) => (
              <TabIcon 
                icon={icons.ferramentas}
                color={color}
                name='Serviços'
                focused={focused}
              />
            )
          }}
        />
        <Tabs.Screen 
          name='carrinho'
          options={{ 
            title: 'Carrinho', 
            headerShown: false,
            tabBarIcon: ({ color, focused }) => (
              <TabIcon 
                icon={icons.carrinhoDeCompras}
                color={color}
                name='Carrinho'
                focused={focused}
              />
            )
          }}
        />
        <Tabs.Screen 
          name='perfil'
          options={{ 
            title: 'Perfil', 
            headerShown: false,
            tabBarIcon: ({ color, focused }) => (
              <TabIcon 
                icon={icons.profile}
                color={color}
                name='Perfíl'
                focused={focused}
              />
            )
          }}
        />
      </Tabs>
    </>
  )
}

export default TabsLayout